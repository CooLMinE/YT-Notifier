using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using YTNotifier.Youtube;

namespace YTNotifier
{
    public partial class NewVideosFoundForm : Form
    {
        private YTNotifier.Controls.ListViewColumnSorterNewVideos _listViewColumnSorter = new Controls.ListViewColumnSorterNewVideos();

        public NewVideosFoundForm()
        {
            InitializeComponent();
            listView1.ListViewItemSorter = _listViewColumnSorter;
        }

        private bool ListViewContainsVideoURL(string url)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[2].Text == url)
                    return true;
            }

            return false;
        }

        public void AddVideos(List<YouTubeVideo> videos)
        {
            foreach (YouTubeVideo video in videos)
            {
                if (!ListViewContainsVideoURL(video.URL))
                {
                    listView1.Items.Add(new ListViewItem(new string[] { 
                        video.ChannelName,
                        video.Title,
                        video.URL, 
                        video.Duration,
                        video.Date 
                    }));
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hitTest = listView1.HitTest(e.Location);

            if (hitTest.Item != null)
            {
                System.Diagnostics.Process.Start(hitTest.Item.SubItems[2].Text);
            }
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == _listViewColumnSorter.SortColumn)
            {
                _listViewColumnSorter.Order = _listViewColumnSorter.Order == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            }
            else
            {
                _listViewColumnSorter.SortColumn = e.Column;
                _listViewColumnSorter.Order = SortOrder.Ascending;
            }

            this.listView1.Sort();
        }

        private void NewVideosFoundForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
