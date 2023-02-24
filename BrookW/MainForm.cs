using BrookW.Brook.Service;
using BrookW.Brook.Model;
using BrookW.Brook.Helper;
using BrookW.Extend;

namespace BrookW
{
    public partial class MainForm : Form
    {
        private BrookProcessService? brookClient;

        /// <summary>
        /// 
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // �������ļ���ȡ����
            serverAddressTextBox.Text = Properties.Settings.Default.ServerAddress;
            passwordTextBox.Text = Properties.Settings.Default.Password;
            comboBox1.Text = Properties.Settings.Default.ServerType;

            statusLabel.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.favicon16;
            notifyIcon.Visible = true;
            notifyIcon.Icon = Icon;
            //this.WindowState = FormWindowState.Minimized;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // ���ش��ڣ���������С�������½ǵ�֪ͨ����
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }
            else
            {
                // ���������˳�
                Exit();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = Msg.ShowConfirm("ȷ��Ҫ�˳��ó�����?");
            if (dialog == DialogResult.OK)
            {
                Exit();
            }
        }

        /// <summary>
        /// �˳�Ӧ�ó���
        /// </summary>
        private void Exit()
        {
            brookClient?.Stop();
            notifyIcon.Dispose();
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ��ʾ���ô���
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void saveConfig()
        {
            // �������õ������ļ�
            Properties.Settings.Default.ServerAddress = serverAddressTextBox.Text.Trim();
            Properties.Settings.Default.Password = passwordTextBox.Text.Trim();
            Properties.Settings.Default.ServerType = comboBox1.Text.Trim();
            Properties.Settings.Default.Save();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            saveConfig();

            // ���� Brook �ͻ���
            string serverAddress = serverAddressTextBox.Text;
            if (string.IsNullOrEmpty(serverAddress))
            {
                Msg.ShowError("��������ַ����Ϊ��");
                return;
            }
            string password = passwordTextBox.Text;
            if (string.IsNullOrEmpty(password))
            {
                Msg.ShowError("���벻��Ϊ��");
                return;
            }
            var type = (Brook.Model.Enum.BrookClientTypeEnum)comboBox1.SelectedIndex;
            var server = new Server()
            {
                Type = type,
                Password = password,
                Url = serverAddress,
            };
            try
            {
                brookClient = new BrookProcessService(server);
                statusLabel.Text = "Brook client started.";
                //http
                SetProxyHelper.EnableProxy($"{brookClient.ListenAddress}:{brookClient.ListenHttpPort}");
                //
                //SetProxyHelper.EnableProxy($"socks5={brookClient.ListenAddress}:{brookClient.ListenSocks5Port}");

                startButton.Enabled = false;
                stopButton.Enabled = true;
            }
            catch (Exception ex)
            {
                Msg.ShowError(ex.Message);
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            // ֹͣ Brook �ͻ���
            brookClient?.Stop();
            statusLabel.Text = "Brook client stopped.";
            startButton.Enabled = true;
            stopButton.Enabled = false;
            SetProxyHelper.DisableProxy();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            // ��������С�������½ǵ�֪ͨ����
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // ��ԭ����
            if (e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }
        }

    }
}