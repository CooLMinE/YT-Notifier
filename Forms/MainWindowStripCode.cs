using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using YTNotifier.Helper_Classes;

namespace YTNotifier
{
    partial class MainWindow
    {

        private void contextMenuStripVideoInfo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text.ToLower())
            {
                case "open in browser":
                    Process.Start(listViewVideoInfo.SelectedItems[0].SubItems[3].Text);
                    break;
                case "copy to clipboard":
                    Clipboard.SetText(listViewVideoInfo.SelectedItems[0].SubItems[3].Text);
                    break;
                case "refresh":
                    RefreshChannelVideoList();
                    break;
            }
        }

        private void contextMenuStripChannels_Opening(object sender, CancelEventArgs e)
        {
            if (listBoxControlChannels.SelectedItem == null)
            {
                for (int i = 1; i < contextMenuStripChannels.Items.Count; i++)
                {
                    if (contextMenuStripChannels.Items[i].Enabled == true)
                    {
                        contextMenuStripChannels.Items[i].Enabled = false;
                        contextMenuStripChannels.Items[i].Visible = false;
                    }
                }
            }
            else
            {
                for (int i = 1; i < contextMenuStripChannels.Items.Count; i++)
                {
                    if (contextMenuStripChannels.Items[i].Enabled == false)
                    {
                        contextMenuStripChannels.Items[i].Enabled = true;
                        contextMenuStripChannels.Items[i].Visible = true;
                    }
                }
            }
        }

        private void contextMenuStripVideoInfo_Opening(object sender, CancelEventArgs e)
        {
            if (listViewVideoInfo.SelectedItems.Count == 0)
                e.Cancel = true;
        }

        private void contextMenuStripChannels_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text.ToLower() == "add channel")
            {
                ShowAddNewChannelForm();
            }
            else if (listBoxControlChannels.SelectedItem != null)
            {
                string selectedItem = listBoxControlChannels.SelectedItem.ToString();
                int selectedItemIndex = listBoxControlChannels.Items.IndexOf(selectedItem);

                switch (e.ClickedItem.Text.ToLower())
                {
                    case "remove":
                        contextMenuStripChannels.Close();
                        RemoveChannel(selectedItem);
                        break;
                    case "move to top":
                        RearrangeChannelOrder(selectedItem, 0);
                        break;
                    case "move up":
                        if (selectedItemIndex > 0)
                            RearrangeChannelOrder(selectedItem, selectedItemIndex - 1);
                        break;
                    case "move down":
                        if (selectedItemIndex < listBoxControlChannels.Items.Count - 1)
                            RearrangeChannelOrder(selectedItem, selectedItemIndex + 1);
                        break;
                    case "move to bottom":
                        RearrangeChannelOrder(selectedItem, listBoxControlChannels.Items.Count);
                        break;
                }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "toolStripButtonAddNewChannel":
                    ShowAddNewChannelForm();
                    break;
                case "toolStripButtonRemoveSelectedChannel":
                    if (listBoxControlChannels.SelectedItem != null)
                        RemoveChannel(listBoxControlChannels.SelectedItem.ToString());
                    break;
                case "toolStripButtonMoveToTop":
                    if (listBoxControlChannels.SelectedItem != null)
                        RearrangeChannelOrder(listBoxControlChannels.SelectedItem.ToString(), 0);
                    break;
                case "toolStripButtonMoveUp":
                    if (listBoxControlChannels.SelectedItem != null)
                    {
                        string selectedItem = listBoxControlChannels.SelectedItem.ToString();
                        int selectedItemIndex = listBoxControlChannels.Items.IndexOf(selectedItem);

                        if (selectedItemIndex > 0)
                            RearrangeChannelOrder(selectedItem, selectedItemIndex - 1);
                    }
                    break;
                case "toolStripButtonMoveToBottom":
                    if (listBoxControlChannels.SelectedItem != null)
                        RearrangeChannelOrder(listBoxControlChannels.SelectedItem.ToString(), listBoxControlChannels.Items.Count);
                    break;
                case "toolStripButtonMoveDown":
                    if (listBoxControlChannels.SelectedItem != null)
                    {
                        string selectedItem = listBoxControlChannels.SelectedItem.ToString();
                        int selectedItemIndex = listBoxControlChannels.Items.IndexOf(selectedItem);

                        if (selectedItemIndex < listBoxControlChannels.Items.Count - 1)
                            RearrangeChannelOrder(selectedItem, selectedItemIndex + 1);
                    }
                    break;
                case "toolStripButtonRefreshSelectedChannel":
                    RefreshChannelVideoList();
                    break;
                case "toolStripButtonCheckForNewVideos":
                    CheckForNewVideos();
                    break;
            }
        }

        private void numberOfVideosToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripMenuItem item = e.ClickedItem as ToolStripMenuItem;
            ToolStripMenuItem parent = sender as ToolStripMenuItem;

            parent.DropDownItems.OfType<ToolStripMenuItem>().Where(x => x.Checked).ToList().ForEach(x => x.Checked = false);
            item.Checked = true;
            Properties.Settings.Default.NumberOfVideosToDisplay = int.Parse(item.Text);
            Properties.Settings.Default.Save();
        }

        private void minimizeToTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
            Properties.Settings.Default.MinimizeToTray = ((ToolStripMenuItem)sender).Checked;
            Properties.Settings.Default.Save();
        }
        
        private void checkForNewVideosToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripMenuItem item = e.ClickedItem as ToolStripMenuItem;
            ToolStripMenuItem parent = sender as ToolStripMenuItem;
            int itemIndex = parent.DropDownItems.IndexOf(item);

            if (itemIndex == 0)
            {
                _automaticallyCheckForNewVideosEnabledChanged = true;
                item.Checked = !item.Checked;
                Properties.Settings.Default.CheckForNewVideos = item.Checked;
                Properties.Settings.Default.Save();

                if (item.Checked)
                {
                    SetCheckForNewVideosMenuStripItemsVisibility(true);
                    if (Properties.Settings.Default.CheckForNewVideosInterval != 0)
                    {
                        timerCheckForNewVideos.Interval = Properties.Settings.Default.CheckForNewVideosInterval;
                        timerCheckForNewVideos.Start();
                    }
                }
                else
                {
                    SetCheckForNewVideosMenuStripItemsVisibility(false);
                    timerCheckForNewVideos.Stop();
                }
            }
            else if (itemIndex > 0)
            {
                parent.DropDownItems.OfType<ToolStripMenuItem>().Skip(1).Where(x => x.Checked).ToList().ForEach(x => x.Checked = false);
                item.Checked = true;
                Properties.Settings.Default.CheckForNewVideosInterval = CustomMillisecondConversion.ConvertToMilliseconds(item.Text);
                Properties.Settings.Default.Save();

                if (Properties.Settings.Default.CheckForNewVideos)
                {
                    timerCheckForNewVideos.Stop();
                    timerCheckForNewVideos.Interval = Properties.Settings.Default.CheckForNewVideosInterval;
                    timerCheckForNewVideos.Start();
                }
                else
                {
                    timerCheckForNewVideos.Interval = Properties.Settings.Default.CheckForNewVideosInterval;
                }
            }
        }

        private void checkNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckForNewVideos();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStripTray_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text.ToLower())
            {
                case "restore":
                    if (!this.Visible)
                    {
                        this.Show();
                        this.ShowInTaskbar = true;
                        this.WindowState = FormWindowState.Normal;
                        this.Activate();
                    }
                    break;
                case "exit":
                    this.Close();
                    break;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBox about = new AboutBox())
            {
                about.ShowDialog();
            }
        }
    }
}
