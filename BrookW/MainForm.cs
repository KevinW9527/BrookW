using BrookW.Extend;
using BrookW.UC;
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
        private UC.ServerSave serverSave;
        private UC.ServerList serverList;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Home
            home = new UC.Home()
            {
                Dock = DockStyle.Fill,
                Location = new Point(0, 0),
                Name = "home",
            };
            home.btnShowServerList.Click += (object? sender, EventArgs e) =>
            {
                serverSave.Hide();
                home.Hide();
                serverList.Show();
            };
            Controls.Add(home);
            home.Show();

            #endregion

            #region ServerList
            serverList = new UC.ServerList()
            {
                Dock = DockStyle.Fill,
                Location = new Point(0, 0),
                Name = "serverList",
            };

            Controls.Add(serverList);
            serverList.Hide();
            serverList.btnGoBackHome.Click += (object? sender, EventArgs e) =>
            {
                serverSave.Hide();
                serverList.Hide();
                home.Show();
                home.LoadServers();
            };
            serverList.btnAddServer.Click += (object? sender, EventArgs e) =>
            {
                home.Hide();
                serverList.Hide();
                serverSave.Show();
            };
            #endregion

            #region ServerSave

            serverSave = new UC.ServerSave()
            {
                Dock = DockStyle.Fill,
                Location = new Point(0, 0),
                Name = "serverSave",
            };
            serverSave.btnGoBackServerList.Click += (object? sender, EventArgs e) =>
            {
                serverSave.Hide();
                home.Hide();
                serverList.Show();
            };
            Controls.Add(serverSave);
            serverSave.Hide(); 
            #endregion

            Icon = Properties.Resources.favicon32;
            notifyIcon.Visible = true;
            notifyIcon.Icon = Icon;
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
            ChangeFormWindowState();
        }


        private void MainForm_Resize(object sender, EventArgs e)
        {
            // 将窗口最小化到右下角的通知区域
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                this.settingsToolStripMenuItem.Text = "显示";
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // 还原窗口
            if (e.Button == MouseButtons.Left)
            {
                ChangeFormWindowState();
            }
        }


        private void ChangeFormWindowState()
        {
            if (WindowState != FormWindowState.Normal)
            {
                // 显示设置窗口
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                this.settingsToolStripMenuItem.Text = "隐藏";
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                this.settingsToolStripMenuItem.Text = "显示";
            }


        }


    }
}
