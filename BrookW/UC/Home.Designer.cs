namespace BrookW.UC
{
    partial class Home
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            TLP_Home = new TableLayoutPanel();
            cbSelectServer = new ComboBox();
            toolStrip1 = new ToolStrip();
            btnShowServerList = new ToolStripButton();
            toolStripButtonRefresh = new ToolStripDropDownButton();
            brookWToolStripMenuItem = new ToolStripMenuItem();
            brookCoreToolStripMenuItem = new ToolStripMenuItem();
            btnShowAppSetting = new ToolStripButton();
            statusLabel = new Label();
            lblServer = new Label();
            panel1 = new Panel();
            pbRun = new PictureBox();
            link_next = new LinkLabel();
            TLP_Home.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRun).BeginInit();
            SuspendLayout();
            // 
            // TLP_Home
            // 
            TLP_Home.ColumnCount = 7;
            TLP_Home.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TLP_Home.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLP_Home.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            TLP_Home.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            TLP_Home.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            TLP_Home.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLP_Home.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TLP_Home.Controls.Add(cbSelectServer, 2, 2);
            TLP_Home.Controls.Add(toolStrip1, 0, 0);
            TLP_Home.Controls.Add(statusLabel, 2, 5);
            TLP_Home.Controls.Add(lblServer, 2, 1);
            TLP_Home.Controls.Add(panel1, 2, 3);
            TLP_Home.Controls.Add(link_next, 5, 2);
            TLP_Home.Dock = DockStyle.Fill;
            TLP_Home.Location = new Point(0, 0);
            TLP_Home.Margin = new Padding(0);
            TLP_Home.Name = "TLP_Home";
            TLP_Home.RowCount = 7;
            TLP_Home.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            TLP_Home.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            TLP_Home.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            TLP_Home.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            TLP_Home.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            TLP_Home.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            TLP_Home.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLP_Home.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TLP_Home.Size = new Size(380, 475);
            TLP_Home.TabIndex = 0;
            // 
            // cbSelectServer
            // 
            cbSelectServer.Anchor = AnchorStyles.Left;
            TLP_Home.SetColumnSpan(cbSelectServer, 3);
            cbSelectServer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSelectServer.FormattingEnabled = true;
            cbSelectServer.Items.AddRange(new object[] { "brook server", "brook wsserver", "brook wssserver", "brook link" });
            cbSelectServer.Location = new Point(73, 123);
            cbSelectServer.Name = "cbSelectServer";
            cbSelectServer.Size = new Size(234, 25);
            cbSelectServer.TabIndex = 6;
            cbSelectServer.SelectedIndexChanged += cbSelectServer_SelectedIndexChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Transparent;
            TLP_Home.SetColumnSpan(toolStrip1, 7);
            toolStrip1.Dock = DockStyle.Fill;
            toolStrip1.GripMargin = new Padding(0);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnShowServerList, toolStripButtonRefresh, btnShowAppSetting });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Margin = new Padding(3, 0, 0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(377, 36);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip";
            // 
            // btnShowServerList
            // 
            btnShowServerList.AutoSize = false;
            btnShowServerList.AutoToolTip = false;
            btnShowServerList.BackgroundImageLayout = ImageLayout.Zoom;
            btnShowServerList.Font = new Font("Microsoft YaHei UI", 10F);
            btnShowServerList.Image = Properties.Resources.server;
            btnShowServerList.ImageAlign = ContentAlignment.MiddleLeft;
            btnShowServerList.ImageTransparentColor = Color.Transparent;
            btnShowServerList.Margin = new Padding(0);
            btnShowServerList.Name = "btnShowServerList";
            btnShowServerList.Size = new Size(75, 34);
            btnShowServerList.Text = "服务器";
            btnShowServerList.TextAlign = ContentAlignment.MiddleRight;
            btnShowServerList.TextDirection = ToolStripTextDirection.Horizontal;
            // 
            // toolStripButtonRefresh
            // 
            toolStripButtonRefresh.AutoSize = false;
            toolStripButtonRefresh.AutoToolTip = false;
            toolStripButtonRefresh.BackgroundImageLayout = ImageLayout.Zoom;
            toolStripButtonRefresh.DropDownItems.AddRange(new ToolStripItem[] { brookWToolStripMenuItem, brookCoreToolStripMenuItem });
            toolStripButtonRefresh.Font = new Font("Microsoft YaHei UI", 10F);
            toolStripButtonRefresh.Image = Properties.Resources.refresh;
            toolStripButtonRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            toolStripButtonRefresh.ImageTransparentColor = Color.Transparent;
            toolStripButtonRefresh.Margin = new Padding(8, 0, 0, 0);
            toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            toolStripButtonRefresh.Size = new Size(95, 34);
            toolStripButtonRefresh.Text = "检查更新";
            toolStripButtonRefresh.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // brookWToolStripMenuItem
            // 
            brookWToolStripMenuItem.BackColor = Color.White;
            brookWToolStripMenuItem.Name = "brookWToolStripMenuItem";
            brookWToolStripMenuItem.Size = new Size(153, 24);
            brookWToolStripMenuItem.Text = "BrookW";
            brookWToolStripMenuItem.Click += brookWToolStripMenuItem_Click;
            // 
            // brookCoreToolStripMenuItem
            // 
            brookCoreToolStripMenuItem.BackColor = Color.White;
            brookCoreToolStripMenuItem.Name = "brookCoreToolStripMenuItem";
            brookCoreToolStripMenuItem.Size = new Size(153, 24);
            brookCoreToolStripMenuItem.Text = "Brook Core";
            brookCoreToolStripMenuItem.Click += brookCoreToolStripMenuItem_Click;
            // 
            // btnShowAppSetting
            // 
            btnShowAppSetting.AutoSize = false;
            btnShowAppSetting.AutoToolTip = false;
            btnShowAppSetting.BackgroundImageLayout = ImageLayout.Zoom;
            btnShowAppSetting.Font = new Font("Microsoft YaHei UI", 10F);
            btnShowAppSetting.Image = Properties.Resources.setting;
            btnShowAppSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnShowAppSetting.ImageTransparentColor = Color.Transparent;
            btnShowAppSetting.Margin = new Padding(15, 0, 0, 0);
            btnShowAppSetting.Name = "btnShowAppSetting";
            btnShowAppSetting.Size = new Size(60, 34);
            btnShowAppSetting.Text = "设置";
            btnShowAppSetting.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            TLP_Home.SetColumnSpan(statusLabel, 3);
            statusLabel.Dock = DockStyle.Top;
            statusLabel.Font = new Font("Microsoft YaHei UI", 10F);
            statusLabel.Location = new Point(73, 336);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(234, 20);
            statusLabel.TabIndex = 8;
            statusLabel.Text = "server status";
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblServer
            // 
            lblServer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblServer.AutoSize = true;
            TLP_Home.SetColumnSpan(lblServer, 2);
            lblServer.Font = new Font("Microsoft YaHei UI", 10F);
            lblServer.Location = new Point(70, 76);
            lblServer.Margin = new Padding(0);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(48, 20);
            lblServer.TabIndex = 1;
            lblServer.Text = "server";
            // 
            // panel1
            // 
            TLP_Home.SetColumnSpan(panel1, 3);
            panel1.Controls.Add(pbRun);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(70, 176);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            TLP_Home.SetRowSpan(panel1, 2);
            panel1.Size = new Size(240, 160);
            panel1.TabIndex = 13;
            // 
            // pbRun
            // 
            pbRun.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbRun.BackColor = Color.Transparent;
            pbRun.BackgroundImageLayout = ImageLayout.Zoom;
            pbRun.Cursor = Cursors.Hand;
            pbRun.Location = new Point(55, 25);
            pbRun.Margin = new Padding(0);
            pbRun.Name = "pbRun";
            pbRun.Size = new Size(130, 130);
            pbRun.TabIndex = 12;
            pbRun.TabStop = false;
            pbRun.Click += pbRun_Click;
            // 
            // link_next
            // 
            link_next.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            link_next.AutoSize = true;
            link_next.Location = new Point(310, 96);
            link_next.Margin = new Padding(0);
            link_next.Name = "link_next";
            link_next.Size = new Size(50, 80);
            link_next.TabIndex = 14;
            link_next.TabStop = true;
            link_next.Text = "Next";
            link_next.TextAlign = ContentAlignment.MiddleCenter;
            link_next.LinkClicked += link_next_LinkClicked;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(TLP_Home);
            Name = "Home";
            Size = new Size(380, 475);
            TLP_Home.ResumeLayout(false);
            TLP_Home.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbRun).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TLP_Home;
        private Label lblServer;
        public ComboBox cbSelectServer;
        private ToolStrip toolStrip1;
        public ToolStripButton btnShowServerList;
        public ToolStripButton btnShowAppSetting;
        public ToolStripDropDownButton toolStripButtonRefresh;
        private ToolStripMenuItem brookWToolStripMenuItem;
        private ToolStripMenuItem brookCoreToolStripMenuItem;
        private PictureBox pbRun;
        private Panel panel1;
        public Label statusLabel;
        private LinkLabel link_next;
    }
}
