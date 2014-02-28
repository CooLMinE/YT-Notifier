using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using YTNotifier.Forms;
using YTNotifier.Helper_Classes;
using YTNotifier.Youtube;

namespace YTNotifier
{
    public partial class MainWindow : DevExpress.XtraEditors.XtraForm
    {
        private YTNotifier.Controls.ListViewColumnSorter _listViewColumnSorter = new YTNotifier.Controls.ListViewColumnSorter();
        volatile bool _isClosing = false;
        bool _isRearrangingChannels = false;
        bool _automaticallyCheckForNewVideosEnabledChanged = false;
        BackgroundWorker _rssThread;
        int _invalidChannelIndex = -1;
        NewVideosFoundForm _newVideoFoundForm = new NewVideosFoundForm();

        public MainWindow()
        {
            InitializeComponent();
            checkForNewVideosToolStripMenu.DropDown.Closing += checkForNewVideosDropDown_Closing;
            _newVideoFoundForm.FormClosing += _newVideoFoundForm_FormClosing;

            listViewVideoInfo.ListViewItemSorter = _listViewColumnSorter;
            listViewVideoInfo.Columns[2].Width = -2;
            listViewVideoInfo.Columns[listViewVideoInfo.Columns.Count - 1].Width = -2;

            if (Properties.Settings.Default.UpgradeSettings)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.UpgradeSettings = false;
                Properties.Settings.Default.Save();
            }

            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(listViewVideoInfo, true, null);

            if (Properties.Settings.Default.ChannelInformation == null)
                Properties.Settings.Default.ChannelInformation = new StringCollection();

            if (Properties.Settings.Default.ChannelList == null)
                Properties.Settings.Default.ChannelList = new StringCollection();

            LoadApplicationSettings();
        }

        void _newVideoFoundForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (notifyIcon1.Visible)
                notifyIcon1.Icon = Properties.Resources.YT_Notifier;

        }

        private void LoadApplicationSettings()
        {
            // check number of videos settings
            numberOfVideosToolStripMenu.DropDownItems.OfType<ToolStripMenuItem>()
                .Where(x => x.Text == Properties.Settings.Default.NumberOfVideosToDisplay.ToString())
                .First().Checked = true;

            //check if minimize on tray
            minimizeToTrayToolStripMenuItem.Checked = Properties.Settings.Default.MinimizeToTray;

            //check for new videos
            EnableCheckForNewVideosToolStripMenuItem.Checked = Properties.Settings.Default.CheckForNewVideos;
            SetCheckForNewVideosMenuStripItemsVisibility(Properties.Settings.Default.CheckForNewVideos);

            //check videos interval
            if (Properties.Settings.Default.CheckForNewVideosInterval != 0)
            {
                checkForNewVideosToolStripMenu.DropDownItems.OfType<ToolStripMenuItem>()
                    .Where(x => x.Text == CustomMillisecondConversion.ConvertFromMilliseconds(Properties.Settings.Default.CheckForNewVideosInterval))
                        .First().Checked = true;

                if (Properties.Settings.Default.CheckForNewVideos)
                {
                    timerCheckForNewVideos.Interval = Properties.Settings.Default.CheckForNewVideosInterval;
                    timerCheckForNewVideos.Start();
                }
            }

            listBoxControlChannels.Items.AddRange(Properties.Settings.Default.ChannelList.OfType<string>().ToArray());
        }

        void rssThread_DoWork(object sender, DoWorkEventArgs e)
        {
            string channelName = e.Argument as string;
            try
            {
                toolStripStatusLabel1.Text = "Fetching channel information, please wait...";
                YouTubeChannnel channel = YouTubeHelper.GetYoutubeChannel(channelName);

                int totalVideos = channel.GetNumberOfVideosAvailable() > Properties.Settings.Default.NumberOfVideosToDisplay ? Properties.Settings.Default.NumberOfVideosToDisplay : channel.GetNumberOfVideosAvailable();

                if (totalVideos > 0)
                {
                    Invoke((MethodInvoker)delegate()
                    {
                        toolStripProgressBar1.Maximum = totalVideos;
                        toolStripProgressBar1.Value = 0;
                    });
                    toolStripStatusLabelProgress.Text = string.Format("{0} / {1}", toolStripProgressBar1.Value, totalVideos);
                    toolStripStatusLabel1.Text = "Loading " + channel.ChannelName + " videos, please wait.";

                    CustomSettingDictionary.TryAddEntry(channelName, channel.GetLatestVideo().URL, channel.GetLatestVideo().Date);

                    foreach (YouTubeVideo video in channel.GetVideos(Properties.Settings.Default.NumberOfVideosToDisplay))
                    {
                        if (((BackgroundWorker)sender).CancellationPending)
                            return;

                        Invoke((MethodInvoker)delegate()
                        {
                            listViewVideoInfo.Items.Add(new ListViewItem(new string[] { video.Title, video.Date, video.Duration, video.URL, String.Format("{0:n0}", int.Parse(video.Views)) }));
                            toolStripProgressBar1.PerformStep();
                        });
                        toolStripStatusLabelProgress.Text = string.Format("{0} / {1}", toolStripProgressBar1.Value, totalVideos);

                    }
                    toolStripStatusLabel1.Text = "Operation completed successfully.";
                }
                else
                {
                    toolStripStatusLabel1.Text = "Channel " + channelName + " contains no videos.";
                }
            }
            catch (Exception ex)
            {
                if (!((BackgroundWorker)sender).CancellationPending)
                {
                    toolStripStatusLabel1.Text = "Error: " + ex.Message;
                    _invalidChannelIndex = listBoxControlChannels.Items.IndexOf(channelName);
                    listBoxControlChannels.Invalidate();
                }
            }
            finally
            {
                if (listBoxControlChannels.Items.Count < 1)
                    toolStripStatusLabel1.Text = string.Empty;
            }
        }

        private void RefreshChannelVideoList()
        {
            if (listBoxControlChannels.SelectedIndex != -1)
            {
                if (_rssThread != null)
                {
                    _rssThread.CancelAsync();
                }
                _invalidChannelIndex = -1;
                listBoxControlChannels.Invalidate();
                listViewVideoInfo.Items.Clear();
                toolStripProgressBar1.Value = 0;
                toolStripStatusLabelProgress.Text = "0 / 0";

                _rssThread = new BackgroundWorker();
                _rssThread.DoWork += new DoWorkEventHandler(rssThread_DoWork);
                _rssThread.WorkerSupportsCancellation = true;
                _rssThread.RunWorkerAsync(listBoxControlChannels.SelectedItem.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CheckForNewVideosInterval != 0 && Properties.Settings.Default.CheckForNewVideos)
            {
                CheckForNewVideos();
            }
        }

        private void ShowAddNewChannelForm()
        {
            using (AddChannelForm form = new AddChannelForm(this))
            {
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    TryAddChannel(form.ChannelName);
                }
            }
        }

        public bool ChannelAlreadyExistsInList(string channelName)
        {
            return listBoxControlChannels.Items.OfType<string>().Where(x => x.Equals(channelName.Trim(), StringComparison.InvariantCultureIgnoreCase)).Select(x => x).Count() > 0;
        }

        private bool TryAddChannel(string channelName)
        {
            bool result = false;

            if (channelName.Trim().Length <= 0)
            {
                MessageBox.Show("Please enter a channel name to add to the list", "Invalid channel name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ChannelAlreadyExistsInList(channelName))
            {
                MessageBox.Show("Your list already contains a channel with the name " + channelName, "Channel already exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listBoxControlChannels.Items.Add(channelName);

                if (!CustomSettingDictionary.ContainsKey(channelName))
                {
                    CustomSettingDictionary.AddEntry(channelName, "", "");
                    Properties.Settings.Default.ChannelList.Add(channelName);
                    Properties.Settings.Default.Save();
                    result = true;
                    textEditChannelName.Text = string.Empty;
                }
            }
            return result;
        }

        private void RemoveChannel(string channelName)
        {
            if (MessageBox.Show("Are you sure you want remove channel " + channelName + " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                listBoxControlChannels.Items.Remove(channelName);
                CustomSettingDictionary.RemoveEntry(channelName);
                Properties.Settings.Default.ChannelList.Remove(channelName);
                Properties.Settings.Default.Save();
            }
        }

        private void RearrangeChannelOrder(string item, int indexToPlace)
        {
            _invalidChannelIndex = -1;
            _isRearrangingChannels = true;
            listBoxControlChannels.Items.Remove(item);
            int newItemIndex = indexToPlace > listBoxControlChannels.Items.Count ? listBoxControlChannels.Items.Count : indexToPlace;
            listBoxControlChannels.Items.Insert(newItemIndex, item);
            listBoxControlChannels.SelectedItem = item;
            _isRearrangingChannels = false;
            SaveChangesToChannelList();
        }

        private void SaveChangesToChannelList()
        {
            Properties.Settings.Default.ChannelList.Clear();
            Properties.Settings.Default.ChannelList.AddRange(listBoxControlChannels.Items.OfType<string>().ToArray());
            Properties.Settings.Default.Save();
        }

        private void CheckForNewVideos()
        {
            new System.Threading.Thread(delegate()
                {
                    try
                    {
                        toolStripStatusLabel1.Text = "Checking for new videos...";
                        List<YouTubeVideo> newVideosList = new List<YouTubeVideo>();

                        foreach (string channel in listBoxControlChannels.Items)
                        {
                            if (!CustomSettingDictionary.ContainsKey(channel))
                                CustomSettingDictionary.AddEntry(channel, "", "");

                            string oldURL = CustomSettingDictionary.GetKeyURL(channel);
                            string oldDate = CustomSettingDictionary.GetKeyDate(channel);
                            YouTubeChannnel chan = YouTubeHelper.GetYoutubeChannel(channel);

                            foreach (YouTubeVideo video in chan.GetVideos().Reverse())
                            {
                                if (_isClosing)
                                    return;

                                DateTime videoDate, oldVideoDate;
                                if (DateTime.TryParse(video.Date, out videoDate) && DateTime.TryParse(oldDate, out oldVideoDate))
                                {
                                    if (string.IsNullOrEmpty(oldDate) || videoDate > oldVideoDate)
                                    {
                                        if (oldURL != video.URL || string.IsNullOrEmpty(oldURL))
                                        {
                                            newVideosList.Add(video);
                                            CustomSettingDictionary.SetValue(channel, video.URL, video.Date);
                                        }
                                    }
                                }
                                else if (oldURL != video.URL || string.IsNullOrEmpty(oldURL))
                                {
                                    newVideosList.Add(video);
                                    CustomSettingDictionary.SetValue(channel, video.URL, video.Date);
                                }
                            }
                        }

                        if (newVideosList.Count > 0)
                        {
                            toolStripStatusLabel1.Text = string.Format("{0} new {1} found !", newVideosList.Count, newVideosList.Count > 1 ? "videos" : "video");
                            Invoke((MethodInvoker)delegate { DisplayNewVideosInNewForm(newVideosList); });
                        }
                        else
                            toolStripStatusLabel1.Text = "No new videos found.";
                    }
                    catch (System.Net.WebException ex)
                    {
                        toolStripStatusLabel1.Text = "Error:" + ex.Message;
                    }
                }).Start();
        }

        private void DisplayNewVideosInNewForm(List<YouTubeVideo> videoList)
        {
            videoList.Reverse();
            notifyIcon1.BalloonTipTitle = string.Format("{0} new {1} found !", videoList.Count, videoList.Count == 1 ? "video" : "videos");
            string text = string.Empty;

            foreach (YouTubeVideo video in videoList)
            {
                text += video.Title + " by " + video.ChannelName + Environment.NewLine + Environment.NewLine;
            }
            notifyIcon1.BalloonTipText = text;
            notifyIcon1.ShowBalloonTip(4000);
            notifyIcon1.Icon = Properties.Resources.new_video_icon;

            using (SoundPlayer sound = new SoundPlayer(Properties.Resources.notification))
            {
                sound.Play();
            }

            if (Application.OpenForms.OfType<NewVideosFoundForm>().Any())
            {
                _newVideoFoundForm.AddVideos(videoList);
            }
            else
            {
                _newVideoFoundForm.AddVideos(videoList);
                _newVideoFoundForm.ShowDialog(this);
            }
        }

        private void timerCheckForNewVideos_Tick(object sender, EventArgs e)
        {
            CheckForNewVideos();
        }

        private void SetCheckForNewVideosMenuStripItemsVisibility(bool setting)
        {
            foreach (var item in checkForNewVideosToolStripMenu.DropDownItems)
            {
                if (item is ToolStripSeparator)
                    ((ToolStripSeparator)item).Visible = setting;
                else if (item is ToolStripMenuItem)
                {
                    if (((ToolStripMenuItem)item) == checkForNewVideosToolStripMenu.DropDownItems[0])
                    {
                        continue;
                    }
                    ((ToolStripMenuItem)item).Visible = setting;
                }
            }
        }

    }
}
