namespace QuickStartApp
{
    partial class frmMain
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.listViewQuickStart = new System.Windows.Forms.ListView();
            this.imageListShortCut = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnShutdown = new System.Windows.Forms.ToolStripButton();
            this.btnRestart = new System.Windows.Forms.ToolStripButton();
            this.btnSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuItemEventLog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDevMgmt = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDiskMgmt = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemControlPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.編輯快速啟動設定檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟圖示資料夾ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTaskMgr = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 421);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(415, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(29, 17);
            this.lblStatus.Text = "N/A";
            // 
            // listViewQuickStart
            // 
            this.listViewQuickStart.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listViewQuickStart.HideSelection = false;
            this.listViewQuickStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listViewQuickStart.LargeImageList = this.imageListShortCut;
            this.listViewQuickStart.Location = new System.Drawing.Point(9, 45);
            this.listViewQuickStart.Margin = new System.Windows.Forms.Padding(0, 6, 0, 3);
            this.listViewQuickStart.MultiSelect = false;
            this.listViewQuickStart.Name = "listViewQuickStart";
            this.listViewQuickStart.Size = new System.Drawing.Size(397, 373);
            this.listViewQuickStart.TabIndex = 3;
            this.listViewQuickStart.UseCompatibleStateImageBehavior = false;
            // 
            // imageListShortCut
            // 
            this.imageListShortCut.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListShortCut.ImageSize = new System.Drawing.Size(52, 52);
            this.imageListShortCut.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShutdown,
            this.btnRestart,
            this.btnSettings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.toolStrip1.Size = new System.Drawing.Size(415, 39);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnShutdown
            // 
            this.btnShutdown.Image = global::QuickStartApp.Properties.Resources._switch;
            this.btnShutdown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(88, 28);
            this.btnShutdown.Text = "電腦關機";
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Image = global::QuickStartApp.Properties.Resources.refresh;
            this.btnRestart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(88, 28);
            this.btnRestart.Text = "重新開機";
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemTaskMgr,
            this.menuItemEventLog,
            this.menuItemDevMgmt,
            this.menuItemDiskMgmt,
            this.menuItemControlPanel,
            this.toolStripSeparator2,
            this.編輯快速啟動設定檔ToolStripMenuItem,
            this.開啟圖示資料夾ToolStripMenuItem,
            this.toolStripSeparator3,
            this.menuItemHelp});
            this.btnSettings.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(12, 0, 6, 0);
            this.btnSettings.Size = new System.Drawing.Size(65, 28);
            this.btnSettings.Text = "設定";
            // 
            // menuItemEventLog
            // 
            this.menuItemEventLog.Name = "menuItemEventLog";
            this.menuItemEventLog.Size = new System.Drawing.Size(201, 30);
            this.menuItemEventLog.Text = "開啟事件檢視";
            this.menuItemEventLog.Click += new System.EventHandler(this.menuItemEventLog_Click);
            // 
            // menuItemDevMgmt
            // 
            this.menuItemDevMgmt.Name = "menuItemDevMgmt";
            this.menuItemDevMgmt.Size = new System.Drawing.Size(201, 30);
            this.menuItemDevMgmt.Text = "開啟裝置管理員";
            this.menuItemDevMgmt.Click += new System.EventHandler(this.menuItemDevMgmt_Click);
            // 
            // menuItemDiskMgmt
            // 
            this.menuItemDiskMgmt.Name = "menuItemDiskMgmt";
            this.menuItemDiskMgmt.Size = new System.Drawing.Size(201, 30);
            this.menuItemDiskMgmt.Text = "開啟磁碟管理";
            this.menuItemDiskMgmt.Click += new System.EventHandler(this.menuItemDiskMgmt_Click);
            // 
            // menuItemControlPanel
            // 
            this.menuItemControlPanel.Image = global::QuickStartApp.Properties.Resources.setting;
            this.menuItemControlPanel.Name = "menuItemControlPanel";
            this.menuItemControlPanel.Size = new System.Drawing.Size(201, 30);
            this.menuItemControlPanel.Text = "開啟控制台";
            this.menuItemControlPanel.Click += new System.EventHandler(this.menuItemControlPanel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(198, 6);
            // 
            // 編輯快速啟動設定檔ToolStripMenuItem
            // 
            this.編輯快速啟動設定檔ToolStripMenuItem.Name = "編輯快速啟動設定檔ToolStripMenuItem";
            this.編輯快速啟動設定檔ToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.編輯快速啟動設定檔ToolStripMenuItem.Text = "編輯快速啟動設定檔";
            // 
            // 開啟圖示資料夾ToolStripMenuItem
            // 
            this.開啟圖示資料夾ToolStripMenuItem.Name = "開啟圖示資料夾ToolStripMenuItem";
            this.開啟圖示資料夾ToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.開啟圖示資料夾ToolStripMenuItem.Text = "開啟圖示資料夾";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(198, 6);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.Image = global::QuickStartApp.Properties.Resources.help;
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(201, 30);
            this.menuItemHelp.Text = "幫助...";
            this.menuItemHelp.Click += new System.EventHandler(this.menuItemHelp_Click);
            // 
            // menuItemTaskMgr
            // 
            this.menuItemTaskMgr.Name = "menuItemTaskMgr";
            this.menuItemTaskMgr.Size = new System.Drawing.Size(201, 30);
            this.menuItemTaskMgr.Text = "開啟工作管理員";
            this.menuItemTaskMgr.Click += new System.EventHandler(this.menuItemTaskMgr_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(415, 443);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listViewQuickStart);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "快速啟動";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ListView listViewQuickStart;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnShutdown;
        private System.Windows.Forms.ToolStripButton btnRestart;
        private System.Windows.Forms.ImageList imageListShortCut;
        private System.Windows.Forms.ToolStripDropDownButton btnSettings;
        private System.Windows.Forms.ToolStripMenuItem menuItemEventLog;
        private System.Windows.Forms.ToolStripMenuItem menuItemDevMgmt;
        private System.Windows.Forms.ToolStripMenuItem menuItemDiskMgmt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuItemControlPanel;
        private System.Windows.Forms.ToolStripMenuItem 編輯快速啟動設定檔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟圖示資料夾ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem menuItemTaskMgr;
    }
}

