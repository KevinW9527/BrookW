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
    public partial class Form1 : Form
    {
        private UC.Home home;
        private UC.SaveServer addServer;

        public Form1()
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
            home.btnAddServer.Click += BtnAddServer_Click;
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
        }

        private void BtnGoBack_Click(object? sender, EventArgs e)
        {
            addServer.Hide();
            home.Show();
        }

        private void BtnAddServer_Click(object? sender, EventArgs e)
        {
            addServer.Show();
            home.Hide();
        }
    }
}
