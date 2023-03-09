using BrookW.Extend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrookW
{
    public partial class MainForm : Form
    {
        private UC.Home home;
        private UC.SaveServer addServer;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            home = new UC.Home()
            {
                Dock = DockStyle.Fill,
                Location = new Point(0, 0),
                Name = "home",
            };
            home.toolStripButtonServer.Click += BtnAddServer_Click;
            Controls.Add(home);
            home.Show();

            addServer = new UC.SaveServer()
            {
                Dock = DockStyle.Fill,
                Location = new Point(0, 0),
                Name = "addServer",
            };
            addServer.btnGoBack.Click += BtnGoBack_Click;
            Controls.Add(addServer);
            addServer.Hide();

            Icon = Properties.Resources.favicon32;
            notifyIcon.Visible = true;
            notifyIcon.Icon = Icon;
        }

        private void BtnGoBack_Click(object? sender, EventArgs e)
        {
            addServer.Hide();
            home.Show();
            home.LoadServers();
        }

        private void BtnAddServer_Click(object? sender, EventArgs e)
        {
            addServer.Show();
            home.Hide();
        }




        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // 隐藏窗口，将窗口最小化到右下角的通知区域
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }
            else
            {
                // 进程意外退出
                Exit();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = Msg.ShowConfirm("确认要退出该程序吗?");
            if (dialog == DialogResult.OK)
            {
                Exit();
            }
        }

        /// <summary>
        /// 退出应用程序
        /// </summary>
        private void Exit()
        {
            home.brookClient?.Stop();
            notifyIcon.Dispose();
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 显示设置窗口
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }


        private void MainForm_Resize(object sender, EventArgs e)
        {
            // 将窗口最小化到右下角的通知区域
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // 还原窗口
            if (e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }
        }



    }
}
