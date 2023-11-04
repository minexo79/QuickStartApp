using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuickStartApp.Models;
using QuickStartApp.Parser;
using Shaman.WinForms;

namespace QuickStartApp
{
    public partial class frmMain : Form
    {
        string AppVersion   { get => "版本 " + Application.ProductVersion; }
        string imgPath      { get => Path.Combine(Application.LocalUserAppDataPath, @"img");  }

        YamlParser parser;
        List<ApplicationModel> model;

        public frmMain()
        {
            InitializeComponent();

            parser  = new YamlParser();
            model   = parser.Open();

            ToolStripManager.Renderer = Windows7Renderer.Instance;

            // Check Image Directory Exists
            if (!Directory.Exists(imgPath))
                Directory.CreateDirectory(imgPath); // Creare New Image Directory

            lblStatus.Text = AppVersion;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load Image From Img Directory
            imageListShortCut.Images.Clear();
            imageListShortCut.Images.Add("SampleApp", Properties.Resources.simpleapp); // 預設Icon

            foreach (var appIcon in Directory.GetFiles(imgPath))
            {
                // 去掉前面落落長的路徑
                imageListShortCut.Images.Add(appIcon.Replace(imgPath + "\\", ""), Image.FromFile(appIcon));
            }

            // Create Shortcut From yaml
            listViewQuickStart.Items.Clear();
            foreach (var app in model)
            {
                if (app.ImgName == "SampleApp")
                    listViewQuickStart.Items.Add(app.AppName, "SampleApp");
                else
                    listViewQuickStart.Items.Add(app.AppName, app.ImgName);
            }
        }
        private void btnShutdown_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("是否關機?", "提示",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // 下達關機指令
            if (result == DialogResult.Yes)
                Process.Start("shutdown", "/s /t 0");
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("是否重新啟動?", "提示",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // 下達重新起動指令
            if (result == DialogResult.Yes)
                Process.Start("shutdown", "/r");
        }

        private void menuItemTaskMgr_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("taskmgr.exe");
        }

        private void menuItemEventLog_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("eventvwr.msc");
        }

        private void menuItemDevMgmt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("devmgmt.msc");
        }

        private void menuItemDiskMgmt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("diskmgmt.msc");
        }

        private void menuItemControlPanel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("control.exe");
        }

        private void menuItemHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"作者：minexo79 (XOT)\n{AppVersion}", "關於",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
