using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace YTNotifier
{
    partial class MainWindow
    {
        private void listBoxControlChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_isRearrangingChannels)
            {
                _listViewColumnSorter.Order = SortOrder.None;
                RefreshChannelVideoList();
            }
        }

        private void listBoxControlChannels_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                int index = listBoxControlChannels.IndexFromPoint(e.Location);

                if (index != -1)
                    listBoxControlChannels.SelectedItem = listBoxControlChannels.Items[index];
            }
        }

        private void listBoxControlChannels_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && listBoxControlChannels.SelectedItem != null)
            {
                RemoveChannel(listBoxControlChannels.SelectedItem.ToString());
            }
        }

        private void listViewVideoInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hitTest = listViewVideoInfo.HitTest(e.Location);

            if (e.Button == System.Windows.Forms.MouseButtons.Left && hitTest != null)
            {
                Process.Start(hitTest.Item.SubItems[3].Text);
            }
        }

        private void listViewVideoInfo_ColumnClick(object sender, ColumnClickEventArgs e)
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
            this.listViewVideoInfo.Sort();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _isClosing = true;
            notifyIcon1.Visible = false;
            if (_rssThread != null)
            {
                if (_rssThread.IsBusy)
                    _rssThread.CancelAsync();
            }
        }

        private void simpleButtonAddChannel_Click(object sender, EventArgs e)
        {
            TryAddChannel(textEditChannelName.Text.Trim());
        }

        private void textEditChannelName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TryAddChannel(textEditChannelName.Text.Trim());
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MinimizeToTray && this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                }
                this.Activate();
            }
        }

        private void checkForNewVideosDropDown_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            if (e.CloseReason == ToolStripDropDownCloseReason.ItemClicked && _automaticallyCheckForNewVideosEnabledChanged)
            {
                _automaticallyCheckForNewVideosEnabledChanged = false;
                e.Cancel = true;
                ((ToolStripDropDownMenu)sender).Invalidate();

            }
        }
    }
}
