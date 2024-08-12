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
            this.components = new System.ComponentModel.Container();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.timerWatchPython = new System.Windows.Forms.Timer(this.components);
            this.timerDis = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStripNotifyIcon.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStripNotifyIcon;
            this.notifyIcon.Text = "BrookW";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStripNotifyIcon
            // 
            this.contextMenuStripNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStripNotifyIcon.Name = "contextMenuStrip1";
            this.contextMenuStripNotifyIcon.Size = new System.Drawing.Size(101, 48);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.settingsToolStripMenuItem.Text = "隐藏";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "退出";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblCopyright, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 446);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCopyright.Location = new System.Drawing.Point(3, 416);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(358, 30);
            this.lblCopyright.TabIndex = 0;
            this.lblCopyright.Text = "Copyright @ ";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerWatchPython
            // 
            this.timerWatchPython.Enabled = true;
            this.timerWatchPython.Interval = 10000;
            this.timerWatchPython.Tick += new System.EventHandler(this.timerWatchPython_Tick);
            // 
            // timerDis
            // 
            this.timerDis.Interval = 50000;
            this.timerDis.Tick += new System.EventHandler(this.timerDis_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 446);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrookW";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.contextMenuStripNotifyIcon.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStripNotifyIcon;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblCopyright;
        private System.Windows.Forms.Timer timerWatchPython;
        private System.Windows.Forms.Timer timerDis;

        #endregion

        //private UC.Home home1;
    }
}