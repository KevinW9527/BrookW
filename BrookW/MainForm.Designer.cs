namespace BrookW
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            notifyIcon = new NotifyIcon(components);
            contextMenuStripNotifyIcon = new ContextMenuStrip(components);
            settingsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblCopyright = new Label();
            timerWatchPython = new System.Windows.Forms.Timer(components);
            timerTerminateInstances = new System.Windows.Forms.Timer(components);
            nextToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStripNotifyIcon.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon
            // 
            notifyIcon.ContextMenuStrip = contextMenuStripNotifyIcon;
            notifyIcon.Text = "BrookW";
            notifyIcon.Visible = true;
            notifyIcon.MouseDoubleClick += notifyIcon_MouseDoubleClick;
            // 
            // contextMenuStripNotifyIcon
            // 
            contextMenuStripNotifyIcon.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, nextToolStripMenuItem, exitToolStripMenuItem });
            contextMenuStripNotifyIcon.Name = "contextMenuStrip1";
            contextMenuStripNotifyIcon.Size = new Size(181, 92);
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(180, 22);
            settingsToolStripMenuItem.Text = "隐藏";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "退出";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblCopyright, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(364, 468);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.BackColor = Color.Transparent;
            lblCopyright.Dock = DockStyle.Fill;
            lblCopyright.Location = new Point(3, 438);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(358, 30);
            lblCopyright.TabIndex = 0;
            lblCopyright.Text = "Copyright @ ";
            lblCopyright.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerWatchPython
            // 
            timerWatchPython.Enabled = true;
            timerWatchPython.Interval = 15000;
            timerWatchPython.Tick += timerWatchPython_Tick;
            // 
            // timerTerminateInstances
            // 
            timerTerminateInstances.Interval = 5000;
            timerTerminateInstances.Tick += timerTerminateInstances_Tick;
            // 
            // nextToolStripMenuItem
            // 
            nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            nextToolStripMenuItem.Size = new Size(180, 22);
            nextToolStripMenuItem.Text = "Next";
            nextToolStripMenuItem.Click += nextToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(364, 468);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BrookW";
            FormClosing += MainForm_FormClosing;
            Load += Form1_Load;
            Resize += MainForm_Resize;
            contextMenuStripNotifyIcon.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStripNotifyIcon;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblCopyright;
        private System.Windows.Forms.Timer timerWatchPython;
        private System.Windows.Forms.Timer timerTerminateInstances;
        private ToolStripMenuItem nextToolStripMenuItem;

        #endregion

        //private UC.Home home1;
    }
}