using BrookW.Extend;
using BrookW.Helper;
using BrookW.Model;
using BrookW.Model.Enum;
using BrookW.Service;
using BrookW.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TencentCloud.Cvm.V20170312.Models;

namespace BrookW
{
    public partial class MainForm : Form
    {
        private UC.Home home = new();
        private UC.ServerSave serverSave = new();
        private UC.ServerList serverList = new();
        private UC.AppSetting appSetting = new();
        //当前运行的
        public string[]? CurrentInstanceId;

        private DateTime _lastExecutionTime;
        private readonly TimeSpan _cooldownPeriod = TimeSpan.FromMinutes(10);
        private int removeServerLoopCount = 0;

        public MainForm()
        {
            InitializeComponent();
            lblCopyright.Text = $"Copyright @ BrookW 2023-{DateTime.Now.Year + 2}";
            _lastExecutionTime = DateTime.MinValue; // 初始化为最小值
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
                serverList.LoadServers();
                appSetting.Hide();
            };
            home.btnShowAppSetting.Click += (object? sender, EventArgs e) =>
            {
                serverSave.Hide();
                home.Hide();
                serverList.Hide();
                appSetting.Show();
            };

            //Controls.Add(home);
            tableLayoutPanel1.Controls.Add(home, 0, 0);
            home.Show();

            #endregion

            #region ServerList
            serverList = new UC.ServerList()
            {
                Dock = DockStyle.Fill,
                Location = new Point(0, 0),
                Name = "serverList",
            };


            //Controls.Add(serverList);
            tableLayoutPanel1.Controls.Add(serverList, 0, 0);
            serverList.Hide();
            serverList.btnGoBackHome.Click += (object? sender, EventArgs e) =>
            {
                appSetting.Hide();
                serverSave.Hide();
                serverList.Hide();
                home.Show();
                home.LoadServers();
            };
            serverList.btnAddServer.Click += (object? sender, EventArgs e) =>
            {
                appSetting.Hide();
                home.Hide();
                serverList.Hide();
                serverSave.Show();
                serverSave.InitSaveServer();
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
                appSetting.Hide();
                serverSave.Hide();
                home.Hide();
                serverList.Show();
                serverList.LoadServers();
            };
            tableLayoutPanel1.Controls.Add(serverSave, 0, 0);
            serverSave.Hide();
            #endregion

            #region appSetting
            appSetting = new AppSetting()
            {
                Dock = DockStyle.Fill,
                Location = new Point(0, 0),
                Name = "appSetting",
            };
            appSetting.btnGoBackServerList.Click += (object? sender, EventArgs e) =>
            {
                appSetting.Hide();
                serverSave.Hide();
                home.Show();
                serverList.Hide();
            };
            tableLayoutPanel1.Controls.Add(appSetting, 0, 0);
            appSetting.Hide();
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
            try
            {
                if (CurrentInstanceId != null && CurrentInstanceId.Length > 0)
                {
                    var dialog = Msg.ShowConfirmYesNo("是否需要销毁腾讯云CVM？");
                    if (dialog == DialogResult.Yes)
                    {
                        RemoveServer(CurrentInstanceId);
                    }
                }
            }
            catch (Exception ex)
            {
                home.statusLabel.Text = ex.Message;
            }
            finally
            {
                var dialog = Msg.ShowConfirm("确认要退出该程序吗?");
                if (dialog == DialogResult.OK)
                {
                    Exit();
                }
            }
        }

        /// <summary>
        /// 退出应用程序
        /// </summary>
        private void Exit()
        {
            home.brookClient?.Stop();
            SetProxyHelper.DisableProxy();
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

        /// <summary>
        /// 编辑服务器
        /// </summary>
        public void EditServer(Model.Server server)
        {
            home.Hide();
            serverList.Hide();
            serverSave.Show();
            serverSave.InitSaveServer(server);

        }

        /// <summary>
        /// 查看python文件，自动获取服务器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerWatchPython_Tick(object sender, EventArgs e)
        {
            timerWatchPython.Stop();
            try
            {
                //
                var appSetting = JsonHelper.ToObject<TencentCloudSetting>(Properties.Settings.Default.TencentCloudSetting) ?? new TencentCloudSetting();

                if (!string.IsNullOrEmpty(appSetting.Path) && !string.IsNullOrEmpty(appSetting.SecretId) && !string.IsNullOrEmpty(appSetting.SecretKey) && appSetting.Enable)
                {
                    var path = appSetting.Path.IndexOf("full.txt") > -1 ? appSetting.Path : Path.Combine(appSetting.Path, "/full.txt");
                    if (File.Exists(path))
                    {
                        DateTime now = DateTime.Now;
                        // 检查是否在冷却时间内
                        if (now - _lastExecutionTime < _cooldownPeriod)
                        {
                            var p = _cooldownPeriod - (now - _lastExecutionTime);
                            home.statusLabel.Text = $"在{Convert.ToInt32(p.TotalSeconds)}秒内不能再次自动执行";
                        }
                        else
                        {
                           //先停止代理
                            home.brookClient?.Stop();
                            SetProxyHelper.DisableProxy();
                            Thread.Sleep(5000);

                            var spot = new RunInstanceSpot();
                            var instanceIds = string.IsNullOrEmpty(appSetting.LaunchTemplateId) ? spot.RunInstancesByLaunchTemplate(appSetting.SecretId, appSetting.SecretKey)
                                : spot.RunInstancesByLaunchTemplate(appSetting.SecretId, appSetting.SecretKey, appSetting.LaunchTemplateId);

                            if (instanceIds != null && instanceIds.Length > 0)
                            {
                                var instancesPublicIp = spot.GetInstancesPublicIp(instanceIds, appSetting.SecretId, appSetting.SecretKey);
                                if (!string.IsNullOrEmpty(instancesPublicIp))
                                {
                                    var server = AutoAddServer(instancesPublicIp, instanceIds);
                                    File.Delete(path);
                                    if (CurrentInstanceId != null)
                                    {
                                        RemoveServer(CurrentInstanceId);
                                    }
                                    if (server != null)
                                    {
                                        home.Run(server);
                                        //启动销毁计数
                                        timerTerminateInstances.Enabled = true;
                                        timerTerminateInstances.Tag = CurrentInstanceId;
                                        removeServerLoopCount = 0;
                                        CurrentInstanceId = instanceIds;
                                    }
                                }
                            }
                            // 更新上次执行时间
                            _lastExecutionTime = now;
                        }
                    }
                }
                else if (!string.IsNullOrEmpty(appSetting.Path))
                {
                    var path = appSetting.Path.IndexOf("full.txt") > -1 ? appSetting.Path : Path.Combine(appSetting.Path, "/full.txt");
                    if (File.Exists(path))
                    {
                        DateTime now = DateTime.Now;
                        // 检查是否在冷却时间内
                        if (now - _lastExecutionTime < _cooldownPeriod)
                        {
                            var p = _cooldownPeriod - (now - _lastExecutionTime);
                            home.statusLabel.Text = $"在{Convert.ToInt32(p.TotalSeconds)}秒内不能再次自动执行";
                        }
                        else
                        {
                            File.Delete(path);
                            home.RunNext();

                            // 更新上次执行时间
                            _lastExecutionTime = now;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                home.statusLabel.Text = ex.Message;
                //Thread.Sleep(1000 * 5);
            }
            timerWatchPython.Start();
        }

        private Server? AutoAddServer(string? ip, string[] instanceIds)
        {
            try
            {
                var currServers = JsonHelper.ToObject<List<Server>>(Properties.Settings.Default.Servers);
                if (currServers == null)
                {
                    currServers = new List<Server>();
                }
                var server = new Server()
                {
                    Type = BrookClientTypeEnum.WSSCLIENT,
                    Password = "web2023",
                    Url = $"ws://{ip}:3389/web3",
                    Tag = instanceIds[0]
                };

                if (!currServers.Contains(server))
                    currServers.Add(server);

                var json = currServers.GroupBy(x => x.ClientCmdString).Select(g => g.First()).ToList().ToJson();
                Properties.Settings.Default.Servers = json;
                Properties.Settings.Default.Save();
                //刷新列表
                //home.LoadServers();

                return server;
            }
            catch (Exception e)
            {
                home.statusLabel.Text = e.Message;
                return default;
            }
        }

        private void RemoveServer(string[] instanceIds)
        {
            try
            {
                var appSetting = JsonHelper.ToObject<TencentCloudSetting>(Properties.Settings.Default.TencentCloudSetting) ?? new TencentCloudSetting();
                if (!string.IsNullOrEmpty(appSetting.Path) && !string.IsNullOrEmpty(appSetting.SecretId) && !string.IsNullOrEmpty(appSetting.SecretKey))
                {
                    if (instanceIds != null && instanceIds.Length > 0)
                    {
                        home.statusLabel.Text = "RemoveServer：" + instanceIds[0];
                        var rs = new RunInstanceSpot().TerminateInstances(instanceIds, appSetting.SecretId, appSetting.SecretKey);
                        if (rs)
                        {
                            var currServers = JsonHelper.ToObject<List<Server>>(Properties.Settings.Default.Servers);
                            if (currServers == null)
                            {
                                currServers = new List<Server>();
                            }

                            var selectedItem = currServers.First(x => x.Tag == instanceIds[0]);
                            if (selectedItem != null)
                            {
                                currServers.Remove(selectedItem);
                            }
                            Properties.Settings.Default.Servers = currServers.ToJson();
                            Properties.Settings.Default.Save();
                            //刷新列表
                            //home.LoadServers();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                removeServerLoopCount++;
                home.statusLabel.Text = string.Format("{0}-{1}", removeServerLoopCount, e.Message);
            }
        }

        private void timerTerminateInstances_Tick(object sender, EventArgs e)
        {
            timerTerminateInstances.Enabled = false;

            if (timerTerminateInstances.Tag != null)
            {
                var ids = (string[])timerTerminateInstances.Tag;
                RemoveServer(ids);
                //timerTerminateInstances.Tag = null;
            }

        }
    }
}
