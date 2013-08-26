using System;
using System.Windows.Forms;

namespace YTNotifier.Forms
{
    public partial class AddChannelForm : DevExpress.XtraEditors.XtraForm
    {
        MainWindow _parent;
        public string ChannelName { get; private set; }

        public AddChannelForm(MainWindow parent)
        {
            InitializeComponent();
            this._parent = parent;
        }

        private void simpleButtonOK_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Please enter a channel name to add to the list", "Invalid channel name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (_parent.ChannelAlreadyExistsInList(textEdit1.Text))
            {
                MessageBox.Show("Your list already contains a channel with the name " + textEdit1.Text, "Channel already exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.ChannelName = textEdit1.Text.Trim();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                simpleButtonOK.PerformClick();
        }
    }
}