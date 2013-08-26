namespace YTNotifier.Forms
{
    partial class AddChannelForm
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
            this.simpleButtonOK = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButtonOK
            // 
            this.simpleButtonOK.Location = new System.Drawing.Point(37, 53);
            this.simpleButtonOK.Name = "simpleButtonOK";
            this.simpleButtonOK.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonOK.TabIndex = 1;
            this.simpleButtonOK.Text = "OK";
            this.simpleButtonOK.Click += new System.EventHandler(this.simpleButtonOK_Click);
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.Location = new System.Drawing.Point(118, 53);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonCancel.TabIndex = 2;
            this.simpleButtonCancel.Text = "Cancel";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(6, 22);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.NullValuePrompt = "Channel name";
            this.textEdit1.Size = new System.Drawing.Size(215, 20);
            this.textEdit1.TabIndex = 0;
            this.textEdit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit1_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textEdit1);
            this.groupBox1.Controls.Add(this.simpleButtonCancel);
            this.groupBox1.Controls.Add(this.simpleButtonOK);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 91);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Channel";
            // 
            // AddChannelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 110);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.LookAndFeel.SkinName = "Office 2010 Silver";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "AddChannelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Channel";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonOK;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}