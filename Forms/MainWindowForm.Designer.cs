namespace YTNotifier
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.listViewVideoInfo = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.URL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Views = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripVideoInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openInBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripChannels = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.moveToTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToBottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textEditChannelName = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxControlChannels = new DevExpress.XtraEditors.ListBoxControl();
            this.simpleButtonAddChannel = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.numberOfVideosToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForNewVideosToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EnableCheckForNewVideosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerCheckForNewVideos = new System.Windows.Forms.Timer(this.components);
            this.exitToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddNewChannel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemoveSelectedChannel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonMoveToTop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMoveUp = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMoveDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMoveToBottom = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRefreshSelectedChannel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCheckForNewVideos = new System.Windows.Forms.ToolStripButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.contextMenuStripVideoInfo.SuspendLayout();
            this.contextMenuStripChannels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditChannelName.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlChannels)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStripTray.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewVideoInfo
            // 
            this.listViewVideoInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewVideoInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Date,
            this.Duration,
            this.URL,
            this.Views});
            this.listViewVideoInfo.ContextMenuStrip = this.contextMenuStripVideoInfo;
            this.listViewVideoInfo.FullRowSelect = true;
            this.listViewVideoInfo.Location = new System.Drawing.Point(6, 19);
            this.listViewVideoInfo.MultiSelect = false;
            this.listViewVideoInfo.Name = "listViewVideoInfo";
            this.listViewVideoInfo.Size = new System.Drawing.Size(552, 265);
            this.listViewVideoInfo.TabIndex = 1;
            this.listViewVideoInfo.UseCompatibleStateImageBehavior = false;
            this.listViewVideoInfo.View = System.Windows.Forms.View.Details;
            this.listViewVideoInfo.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewVideoInfo_ColumnClick);
            this.listViewVideoInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewVideoInfo_MouseDoubleClick);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 160;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 82;
            // 
            // Duration
            // 
            this.Duration.Text = "Duration";
            this.Duration.Width = 57;
            // 
            // URL
            // 
            this.URL.Text = "URL";
            this.URL.Width = 178;
            // 
            // Views
            // 
            this.Views.Text = "Views";
            // 
            // contextMenuStripVideoInfo
            // 
            this.contextMenuStripVideoInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openInBrowserToolStripMenuItem,
            this.toolStripSeparator4,
            this.copyToClipboardToolStripMenuItem,
            this.toolStripSeparator5,
            this.refreshToolStripMenuItem});
            this.contextMenuStripVideoInfo.Name = "contextMenuStripVideoInfo";
            this.contextMenuStripVideoInfo.Size = new System.Drawing.Size(172, 82);
            this.contextMenuStripVideoInfo.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripVideoInfo_Opening);
            this.contextMenuStripVideoInfo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripVideoInfo_ItemClicked);
            // 
            // openInBrowserToolStripMenuItem
            // 
            this.openInBrowserToolStripMenuItem.Image = global::YTNotifier.Properties.Resources._1349678575_Gnome_System_Log_Out_32;
            this.openInBrowserToolStripMenuItem.Name = "openInBrowserToolStripMenuItem";
            this.openInBrowserToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.openInBrowserToolStripMenuItem.Text = "Open in Browser";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(168, 6);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Image = global::YTNotifier.Properties.Resources._1318561484_gtk_edit;
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.copyToClipboardToolStripMenuItem.Text = "Copy to Clipboard";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(168, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::YTNotifier.Properties.Resources._1318465482_gtk_refresh;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // contextMenuStripChannels
            // 
            this.contextMenuStripChannels.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addChannelToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.toolStripSeparator1,
            this.moveToTopToolStripMenuItem,
            this.moveUpToolStripMenuItem,
            this.moveDownToolStripMenuItem,
            this.moveToBottomToolStripMenuItem});
            this.contextMenuStripChannels.Name = "contextMenuStripChannels";
            this.contextMenuStripChannels.Size = new System.Drawing.Size(162, 142);
            this.contextMenuStripChannels.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripChannels_Opening);
            this.contextMenuStripChannels.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripChannels_ItemClicked);
            // 
            // addChannelToolStripMenuItem
            // 
            this.addChannelToolStripMenuItem.Image = global::YTNotifier.Properties.Resources.edit_add_2;
            this.addChannelToolStripMenuItem.Name = "addChannelToolStripMenuItem";
            this.addChannelToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addChannelToolStripMenuItem.Text = "Add Channel";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Image = global::YTNotifier.Properties.Resources._1318027763_dialog_close;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // moveToTopToolStripMenuItem
            // 
            this.moveToTopToolStripMenuItem.Image = global::YTNotifier.Properties.Resources.go_top_4;
            this.moveToTopToolStripMenuItem.Name = "moveToTopToolStripMenuItem";
            this.moveToTopToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.moveToTopToolStripMenuItem.Text = "Move to Top";
            // 
            // moveUpToolStripMenuItem
            // 
            this.moveUpToolStripMenuItem.Image = global::YTNotifier.Properties.Resources.go_up_5;
            this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
            this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.moveUpToolStripMenuItem.Text = "Move Up";
            // 
            // moveDownToolStripMenuItem
            // 
            this.moveDownToolStripMenuItem.Image = global::YTNotifier.Properties.Resources.go_down_5;
            this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
            this.moveDownToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.moveDownToolStripMenuItem.Text = "Move Down";
            // 
            // moveToBottomToolStripMenuItem
            // 
            this.moveToBottomToolStripMenuItem.Image = global::YTNotifier.Properties.Resources.go_bottom_4;
            this.moveToBottomToolStripMenuItem.Name = "moveToBottomToolStripMenuItem";
            this.moveToBottomToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.moveToBottomToolStripMenuItem.Text = "Move to Bottom";
            // 
            // textEditChannelName
            // 
            this.textEditChannelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditChannelName.Location = new System.Drawing.Point(7, 262);
            this.textEditChannelName.Name = "textEditChannelName";
            this.textEditChannelName.Properties.NullValuePrompt = "Channel name";
            this.textEditChannelName.Size = new System.Drawing.Size(96, 20);
            this.textEditChannelName.TabIndex = 4;
            this.textEditChannelName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEditChannelName_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxControlChannels);
            this.groupBox1.Controls.Add(this.textEditChannelName);
            this.groupBox1.Controls.Add(this.simpleButtonAddChannel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(138, 290);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Channels";
            // 
            // listBoxControlChannels
            // 
            this.listBoxControlChannels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxControlChannels.ContextMenuStrip = this.contextMenuStripChannels;
            this.listBoxControlChannels.Location = new System.Drawing.Point(7, 19);
            this.listBoxControlChannels.Name = "listBoxControlChannels";
            this.listBoxControlChannels.Size = new System.Drawing.Size(124, 240);
            this.listBoxControlChannels.TabIndex = 6;
            this.listBoxControlChannels.SelectedIndexChanged += new System.EventHandler(this.listBoxControlChannels_SelectedIndexChanged);
            this.listBoxControlChannels.DrawItem += new DevExpress.XtraEditors.ListBoxDrawItemEventHandler(this.listBoxControl1_DrawItem);
            this.listBoxControlChannels.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxControlChannels_KeyDown);
            this.listBoxControlChannels.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxControlChannels_MouseDown);
            // 
            // simpleButtonAddChannel
            // 
            this.simpleButtonAddChannel.AllowFocus = false;
            this.simpleButtonAddChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonAddChannel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButtonAddChannel.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.simpleButtonAddChannel.Appearance.Options.UseBackColor = true;
            this.simpleButtonAddChannel.BackgroundImage = global::YTNotifier.Properties.Resources._1318561320_edit_add;
            this.simpleButtonAddChannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simpleButtonAddChannel.Location = new System.Drawing.Point(105, 262);
            this.simpleButtonAddChannel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.simpleButtonAddChannel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonAddChannel.Name = "simpleButtonAddChannel";
            this.simpleButtonAddChannel.Size = new System.Drawing.Size(25, 20);
            this.simpleButtonAddChannel.TabIndex = 5;
            this.simpleButtonAddChannel.Click += new System.EventHandler(this.simpleButtonAddChannel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.groupBox2.Controls.Add(this.listViewVideoInfo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 290);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Video Information";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelProgress,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 345);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(719, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Paint += new System.Windows.Forms.PaintEventHandler(this.statusStrip1_Paint);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(602, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Select a channel to begin";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelProgress
            // 
            this.toolStripStatusLabelProgress.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabelProgress.Name = "toolStripStatusLabelProgress";
            this.toolStripStatusLabelProgress.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Step = 1;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStripTray;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStripTray
            // 
            this.contextMenuStripTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.toolStripSeparator6,
            this.exitToolStripMenuItem1});
            this.contextMenuStripTray.Name = "contextMenuStripTray";
            this.contextMenuStripTray.Size = new System.Drawing.Size(119, 54);
            this.contextMenuStripTray.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripTray_ItemClicked);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(115, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = global::YTNotifier.Properties.Resources.system_log_out_6;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(719, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkNowToolStripMenuItem,
            this.toolStripSeparator9,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // checkNowToolStripMenuItem
            // 
            this.checkNowToolStripMenuItem.Image = global::YTNotifier.Properties.Resources.view_refresh_2;
            this.checkNowToolStripMenuItem.Name = "checkNowToolStripMenuItem";
            this.checkNowToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.checkNowToolStripMenuItem.Text = "Check Now";
            this.checkNowToolStripMenuItem.Click += new System.EventHandler(this.checkNowToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(132, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::YTNotifier.Properties.Resources.system_log_out_6;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizeToTrayToolStripMenuItem,
            this.toolStripSeparator10,
            this.numberOfVideosToolStripMenu,
            this.checkForNewVideosToolStripMenu});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // minimizeToTrayToolStripMenuItem
            // 
            this.minimizeToTrayToolStripMenuItem.Checked = true;
            this.minimizeToTrayToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.minimizeToTrayToolStripMenuItem.Name = "minimizeToTrayToolStripMenuItem";
            this.minimizeToTrayToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.minimizeToTrayToolStripMenuItem.Text = "Minimize to Tray";
            this.minimizeToTrayToolStripMenuItem.Click += new System.EventHandler(this.minimizeToTrayToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(187, 6);
            // 
            // numberOfVideosToolStripMenu
            // 
            this.numberOfVideosToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.numberOfVideosToolStripMenu.Name = "numberOfVideosToolStripMenu";
            this.numberOfVideosToolStripMenu.Size = new System.Drawing.Size(190, 22);
            this.numberOfVideosToolStripMenu.Text = "Number of Videos";
            this.numberOfVideosToolStripMenu.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.numberOfVideosToolStripMenuItem_DropDownItemClicked);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem2.Text = "1";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem3.Text = "5";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem4.Text = "15";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem5.Text = "25";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem6.Text = "35";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem7.Text = "50";
            // 
            // checkForNewVideosToolStripMenu
            // 
            this.checkForNewVideosToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EnableCheckForNewVideosToolStripMenuItem,
            this.toolStripSeparator3,
            this.toolStripMenuItem1,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15});
            this.checkForNewVideosToolStripMenu.Name = "checkForNewVideosToolStripMenu";
            this.checkForNewVideosToolStripMenu.Size = new System.Drawing.Size(190, 22);
            this.checkForNewVideosToolStripMenu.Text = "Check for New Videos";
            this.checkForNewVideosToolStripMenu.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.checkForNewVideosToolStripMenuItem_DropDownItemClicked);
            // 
            // EnableCheckForNewVideosToolStripMenuItem
            // 
            this.EnableCheckForNewVideosToolStripMenuItem.Name = "EnableCheckForNewVideosToolStripMenuItem";
            this.EnableCheckForNewVideosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.EnableCheckForNewVideosToolStripMenuItem.Text = "Enabled";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(129, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItem1.Text = "1 Minute";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItem8.Text = "2 Minutes";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItem9.Text = "3 Minutes";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItem10.Text = "5 Minutes";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItem11.Text = "15 Minutes";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItem12.Text = "30 Minutes";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItem13.Text = "1 Hour";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItem14.Text = "2 Hours";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItem15.Text = "5 Hours";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::YTNotifier.Properties.Resources.document_properties;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timerCheckForNewVideos
            // 
            this.timerCheckForNewVideos.Tick += new System.EventHandler(this.timerCheckForNewVideos_Tick);
            // 
            // exitToolStripMenuItem3
            // 
            this.exitToolStripMenuItem3.Name = "exitToolStripMenuItem3";
            this.exitToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem3.Text = "Exit";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddNewChannel,
            this.toolStripButtonRemoveSelectedChannel,
            this.toolStripSeparator7,
            this.toolStripButtonMoveToTop,
            this.toolStripButtonMoveUp,
            this.toolStripButtonMoveDown,
            this.toolStripButtonMoveToBottom,
            this.toolStripSeparator8,
            this.toolStripButtonRefreshSelectedChannel,
            this.toolStripButtonCheckForNewVideos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(719, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButtonAddNewChannel
            // 
            this.toolStripButtonAddNewChannel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddNewChannel.Image = global::YTNotifier.Properties.Resources.edit_add_2;
            this.toolStripButtonAddNewChannel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddNewChannel.Name = "toolStripButtonAddNewChannel";
            this.toolStripButtonAddNewChannel.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAddNewChannel.Text = "Add new channel";
            // 
            // toolStripButtonRemoveSelectedChannel
            // 
            this.toolStripButtonRemoveSelectedChannel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemoveSelectedChannel.Image = global::YTNotifier.Properties.Resources.list_remove_4;
            this.toolStripButtonRemoveSelectedChannel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveSelectedChannel.Name = "toolStripButtonRemoveSelectedChannel";
            this.toolStripButtonRemoveSelectedChannel.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRemoveSelectedChannel.Text = "Remove selected channel";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonMoveToTop
            // 
            this.toolStripButtonMoveToTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMoveToTop.Image = global::YTNotifier.Properties.Resources.arrow_up_double_3;
            this.toolStripButtonMoveToTop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMoveToTop.Name = "toolStripButtonMoveToTop";
            this.toolStripButtonMoveToTop.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMoveToTop.Text = "Move selected channel to top";
            // 
            // toolStripButtonMoveUp
            // 
            this.toolStripButtonMoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMoveUp.Image = global::YTNotifier.Properties.Resources.arrow_up_3;
            this.toolStripButtonMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMoveUp.Name = "toolStripButtonMoveUp";
            this.toolStripButtonMoveUp.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMoveUp.Text = "Move selected channel up";
            // 
            // toolStripButtonMoveDown
            // 
            this.toolStripButtonMoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMoveDown.Image = global::YTNotifier.Properties.Resources.arrow_down_3;
            this.toolStripButtonMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMoveDown.Name = "toolStripButtonMoveDown";
            this.toolStripButtonMoveDown.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMoveDown.Text = "Move selected channel down";
            // 
            // toolStripButtonMoveToBottom
            // 
            this.toolStripButtonMoveToBottom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMoveToBottom.Image = global::YTNotifier.Properties.Resources.arrow_down_double_3;
            this.toolStripButtonMoveToBottom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMoveToBottom.Name = "toolStripButtonMoveToBottom";
            this.toolStripButtonMoveToBottom.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMoveToBottom.Text = "Move selected channel to bottom";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonRefreshSelectedChannel
            // 
            this.toolStripButtonRefreshSelectedChannel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefreshSelectedChannel.Image = global::YTNotifier.Properties.Resources.view_refresh_7;
            this.toolStripButtonRefreshSelectedChannel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefreshSelectedChannel.Name = "toolStripButtonRefreshSelectedChannel";
            this.toolStripButtonRefreshSelectedChannel.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefreshSelectedChannel.Text = "Refresh selected channel\'s videos";
            // 
            // toolStripButtonCheckForNewVideos
            // 
            this.toolStripButtonCheckForNewVideos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCheckForNewVideos.Image = global::YTNotifier.Properties.Resources.view_refresh_2;
            this.toolStripButtonCheckForNewVideos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCheckForNewVideos.Name = "toolStripButtonCheckForNewVideos";
            this.toolStripButtonCheckForNewVideos.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCheckForNewVideos.Text = "Check for new videos";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 49);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainerControl1.Panel1.MinSize = 100;
            this.splitContainerControl1.Panel1.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainerControl1.Panel2.MinSize = 200;
            this.splitContainerControl1.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(719, 296);
            this.splitContainerControl1.SplitterPosition = 144;
            this.splitContainerControl1.TabIndex = 10;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 367);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2010 Silver";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(350, 250);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YT Notifier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.contextMenuStripVideoInfo.ResumeLayout(false);
            this.contextMenuStripChannels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditChannelName.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlChannels)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStripTray.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewVideoInfo;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Duration;
        private System.Windows.Forms.ColumnHeader URL;
        private System.Windows.Forms.ColumnHeader Views;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripChannels;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripVideoInfo;
        private DevExpress.XtraEditors.TextEdit textEditChannelName;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAddChannel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelProgress;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem moveToTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToBottomToolStripMenuItem;
        private DevExpress.XtraEditors.ListBoxControl listBoxControlChannels;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToTrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfVideosToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForNewVideosToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem EnableCheckForNewVideosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.Timer timerCheckForNewVideos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTray;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem checkNowToolStripMenuItem;        
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddNewChannel;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveSelectedChannel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripButtonMoveToTop;
        private System.Windows.Forms.ToolStripButton toolStripButtonMoveUp;
        private System.Windows.Forms.ToolStripButton toolStripButtonMoveToBottom;
        private System.Windows.Forms.ToolStripButton toolStripButtonMoveDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefreshSelectedChannel;
        private System.Windows.Forms.ToolStripButton toolStripButtonCheckForNewVideos;
        private System.Windows.Forms.ToolStripMenuItem addChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
    }
}

