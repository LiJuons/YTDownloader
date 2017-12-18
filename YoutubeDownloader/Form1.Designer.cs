namespace YoutubeDownloader
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboReso = new System.Windows.Forms.ComboBox();
            this.labelReso = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelPercent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textFName = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabFinder = new System.Windows.Forms.TabPage();
            this.labelInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVidLink = new System.Windows.Forms.LinkLabel();
            this.lblVidTitle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.videosList = new System.Windows.Forms.ListBox();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.txtVidName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.tabDwld = new System.Windows.Forms.TabPage();
            this.radioMP4 = new System.Windows.Forms.RadioButton();
            this.radioMP3 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tabFinder.SuspendLayout();
            this.tabDwld.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Youtube Video URL:";
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(11, 56);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(632, 36);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Enter += new System.EventHandler(this.txtUrl_Enter);
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.Location = new System.Drawing.Point(254, 260);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(146, 49);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(8, 311);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(68, 28);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Status.";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboReso
            // 
            this.comboReso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboReso.FormattingEnabled = true;
            this.comboReso.Items.AddRange(new object[] {
            "144",
            "240",
            "360",
            "480",
            "720",
            "1080",
            "1440",
            "2160"});
            this.comboReso.Location = new System.Drawing.Point(237, 132);
            this.comboReso.Name = "comboReso";
            this.comboReso.Size = new System.Drawing.Size(121, 36);
            this.comboReso.TabIndex = 4;
            // 
            // labelReso
            // 
            this.labelReso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelReso.AutoSize = true;
            this.labelReso.Location = new System.Drawing.Point(62, 135);
            this.labelReso.Name = "labelReso";
            this.labelReso.Size = new System.Drawing.Size(161, 28);
            this.labelReso.TabIndex = 5;
            this.labelReso.Text = "Choose Resolution:";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(9, 338);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(640, 13);
            this.progressBar1.TabIndex = 6;
            // 
            // labelPercent
            // 
            this.labelPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPercent.AutoSize = true;
            this.labelPercent.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercent.Location = new System.Drawing.Point(594, 314);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(29, 23);
            this.labelPercent.TabIndex = 7;
            this.labelPercent.Text = "0%";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter Desired File Name:";
            // 
            // textFName
            // 
            this.textFName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textFName.Location = new System.Drawing.Point(13, 212);
            this.textFName.Name = "textFName";
            this.textFName.Size = new System.Drawing.Size(636, 36);
            this.textFName.TabIndex = 9;
            this.textFName.Enter += new System.EventHandler(this.textFName_Enter);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabFinder);
            this.tabControl.Controls.Add(this.tabDwld);
            this.tabControl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(-1, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(668, 437);
            this.tabControl.TabIndex = 10;
            // 
            // tabFinder
            // 
            this.tabFinder.BackColor = System.Drawing.Color.Azure;
            this.tabFinder.Controls.Add(this.labelInfo);
            this.tabFinder.Controls.Add(this.label5);
            this.tabFinder.Controls.Add(this.lblVidLink);
            this.tabFinder.Controls.Add(this.lblVidTitle);
            this.tabFinder.Controls.Add(this.label6);
            this.tabFinder.Controls.Add(this.label4);
            this.tabFinder.Controls.Add(this.videosList);
            this.tabFinder.Controls.Add(this.btnSearchByName);
            this.tabFinder.Controls.Add(this.txtVidName);
            this.tabFinder.Controls.Add(this.labelName);
            this.tabFinder.Location = new System.Drawing.Point(4, 37);
            this.tabFinder.Name = "tabFinder";
            this.tabFinder.Padding = new System.Windows.Forms.Padding(3);
            this.tabFinder.Size = new System.Drawing.Size(660, 396);
            this.tabFinder.TabIndex = 1;
            this.tabFinder.Text = "Finder";
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Eras Light ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(377, 302);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(265, 20);
            this.labelInfo.TabIndex = 11;
            this.labelInfo.Text = "It takes about 5 seconds to load the list.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(495, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Double click on the desired item in the list or on the video link below to procee" +
    "d the download process.";
            // 
            // lblVidLink
            // 
            this.lblVidLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVidLink.AutoSize = true;
            this.lblVidLink.Location = new System.Drawing.Point(131, 335);
            this.lblVidLink.Name = "lblVidLink";
            this.lblVidLink.Size = new System.Drawing.Size(181, 28);
            this.lblVidLink.TabIndex = 9;
            this.lblVidLink.TabStop = true;
            this.lblVidLink.Text = "Video is not selected.";
            // 
            // lblVidTitle
            // 
            this.lblVidTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVidTitle.AutoSize = true;
            this.lblVidTitle.Location = new System.Drawing.Point(131, 305);
            this.lblVidTitle.Name = "lblVidTitle";
            this.lblVidTitle.Size = new System.Drawing.Size(181, 28);
            this.lblVidTitle.TabIndex = 7;
            this.lblVidTitle.Text = "Video is not selected.";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 33);
            this.label6.TabIndex = 6;
            this.label6.Text = "Video link:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "Title:";
            // 
            // videosList
            // 
            this.videosList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videosList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videosList.FormattingEnabled = true;
            this.videosList.ItemHeight = 16;
            this.videosList.Location = new System.Drawing.Point(9, 119);
            this.videosList.Name = "videosList";
            this.videosList.Size = new System.Drawing.Size(639, 180);
            this.videosList.TabIndex = 3;
            this.videosList.SelectedIndexChanged += new System.EventHandler(this.videosList_SelectedIndexChanged);
            this.videosList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.videosList_MouseDoubleClick);
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchByName.Location = new System.Drawing.Point(379, 52);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(121, 37);
            this.btnSearchByName.TabIndex = 2;
            this.btnSearchByName.Text = "Search";
            this.btnSearchByName.UseVisualStyleBackColor = true;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // txtVidName
            // 
            this.txtVidName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVidName.Location = new System.Drawing.Point(9, 52);
            this.txtVidName.Name = "txtVidName";
            this.txtVidName.Size = new System.Drawing.Size(365, 36);
            this.txtVidName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(4, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(165, 28);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Enter Video Name:";
            // 
            // tabDwld
            // 
            this.tabDwld.BackColor = System.Drawing.Color.Azure;
            this.tabDwld.Controls.Add(this.radioMP4);
            this.tabDwld.Controls.Add(this.radioMP3);
            this.tabDwld.Controls.Add(this.label7);
            this.tabDwld.Controls.Add(this.txtUrl);
            this.tabDwld.Controls.Add(this.textFName);
            this.tabDwld.Controls.Add(this.label1);
            this.tabDwld.Controls.Add(this.label3);
            this.tabDwld.Controls.Add(this.comboReso);
            this.tabDwld.Controls.Add(this.labelPercent);
            this.tabDwld.Controls.Add(this.btnDownload);
            this.tabDwld.Controls.Add(this.progressBar1);
            this.tabDwld.Controls.Add(this.labelStatus);
            this.tabDwld.Controls.Add(this.labelReso);
            this.tabDwld.Location = new System.Drawing.Point(4, 37);
            this.tabDwld.Name = "tabDwld";
            this.tabDwld.Padding = new System.Windows.Forms.Padding(3);
            this.tabDwld.Size = new System.Drawing.Size(660, 396);
            this.tabDwld.TabIndex = 0;
            this.tabDwld.Text = "Downloader";
            // 
            // radioMP4
            // 
            this.radioMP4.AutoSize = true;
            this.radioMP4.Location = new System.Drawing.Point(344, 99);
            this.radioMP4.Name = "radioMP4";
            this.radioMP4.Size = new System.Drawing.Size(68, 32);
            this.radioMP4.TabIndex = 12;
            this.radioMP4.TabStop = true;
            this.radioMP4.Text = "MP4";
            this.radioMP4.UseVisualStyleBackColor = true;
            this.radioMP4.Click += new System.EventHandler(this.radioMP4_Click);
            // 
            // radioMP3
            // 
            this.radioMP3.AutoSize = true;
            this.radioMP3.BackColor = System.Drawing.Color.Transparent;
            this.radioMP3.Location = new System.Drawing.Point(237, 99);
            this.radioMP3.Name = "radioMP3";
            this.radioMP3.Size = new System.Drawing.Size(68, 32);
            this.radioMP3.TabIndex = 11;
            this.radioMP3.TabStop = true;
            this.radioMP3.Text = "MP3";
            this.radioMP3.UseVisualStyleBackColor = false;
            this.radioMP3.Click += new System.EventHandler(this.radioMP3_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "Select Format:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 413);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.resetListToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // resetListToolStripMenuItem
            // 
            this.resetListToolStripMenuItem.Name = "resetListToolStripMenuItem";
            this.resetListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resetListToolStripMenuItem.Text = "Reset List";
            this.resetListToolStripMenuItem.Click += new System.EventHandler(this.resetListToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.usageToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // usageToolStripMenuItem
            // 
            this.usageToolStripMenuItem.Name = "usageToolStripMenuItem";
            this.usageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.usageToolStripMenuItem.Text = "Instructions";
            this.usageToolStripMenuItem.Click += new System.EventHandler(this.usageToolStripMenuItem_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(664, 437);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(680, 470);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabFinder.ResumeLayout(false);
            this.tabFinder.PerformLayout();
            this.tabDwld.ResumeLayout(false);
            this.tabDwld.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboReso;
        private System.Windows.Forms.Label labelReso;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textFName;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDwld;
        private System.Windows.Forms.TabPage tabFinder;
        private System.Windows.Forms.ListBox videosList;
        private System.Windows.Forms.Button btnSearchByName;
        private System.Windows.Forms.TextBox txtVidName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label lblVidTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lblVidLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioMP4;
        private System.Windows.Forms.RadioButton radioMP3;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usageToolStripMenuItem;
    }
}

