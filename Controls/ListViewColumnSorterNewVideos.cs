using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YTNotifier.Controls
{
    public class ListViewColumnSorterNewVideos : IComparer
    {
        private int _columnToSort;
        private SortOrder _orderOfSort;
        private CaseInsensitiveComparer _objectCompare;

        public ListViewColumnSorterNewVideos()
        {
            _columnToSort = 0;
            _orderOfSort = SortOrder.None;
            _objectCompare = new CaseInsensitiveComparer();
        }

        public int Compare(object x, object y)
        {
            int compareResult;
            ListViewItem listviewX, listviewY;
            listviewX = (ListViewItem)x;
            listviewY = (ListViewItem)y;

            switch (_columnToSort)
            {
                case 3:
                    string xItem = listviewX.SubItems[_columnToSort].Text.Length == 8 ? listviewX.SubItems[_columnToSort].Text : "00:" + listviewX.SubItems[_columnToSort].Text;
                    string yItem = listviewY.SubItems[_columnToSort].Text.Length == 8 ? listviewY.SubItems[_columnToSort].Text : "00:" + listviewY.SubItems[_columnToSort].Text;

                    compareResult = _objectCompare.Compare(TimeSpan.Parse(yItem), TimeSpan.Parse(xItem));
                    break;
                case 4:
                    compareResult = _objectCompare.Compare(DateTime.Parse(listviewY.SubItems[_columnToSort].Text), DateTime.Parse(listviewX.SubItems[_columnToSort].Text));
                    break;
                default:
                    compareResult = _objectCompare.Compare(listviewX.SubItems[_columnToSort].Text, listviewY.SubItems[_columnToSort].Text);
                    break;
            }

            if (_orderOfSort == SortOrder.Ascending)
                return compareResult;
            else if (_orderOfSort == SortOrder.Descending)
                return (-compareResult);
            else
                return 0;
        }

        public int SortColumn
        {
            set { _columnToSort = value; }
            get { return _columnToSort; }
        }

        public SortOrder Order
        {
            set { _orderOfSort = value; }
            get { return _orderOfSort; }
        }
    }
}
