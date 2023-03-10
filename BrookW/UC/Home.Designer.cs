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
            this.TLP_Home = new System.Windows.Forms.TableLayoutPanel();
            this.cbSelectServer = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonServer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripDropDownButton();
            this.brookWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brookCoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonSetting = new System.Windows.Forms.ToolStripButton();
            this.statusLabel = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblView = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbRun = new System.Windows.Forms.PictureBox();
            this.pbDel = new System.Windows.Forms.PictureBox();
            this.TLP_Home.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            this.SuspendLayout();
            // 
            // TLP_Home
            // 
            this.TLP_Home.ColumnCount = 7;
            this.TLP_Home.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP_Home.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Home.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TLP_Home.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TLP_Home.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TLP_Home.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Home.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP_Home.Controls.Add(this.cbSelectServer, 2, 2);
            this.TLP_Home.Controls.Add(this.toolStrip1, 0, 0);
            this.TLP_Home.Controls.Add(this.statusLabel, 2, 5);
            this.TLP_Home.Controls.Add(this.lblServer, 2, 1);
            this.TLP_Home.Controls.Add(this.lblView, 3, 1);
            this.TLP_Home.Controls.Add(this.panel1, 2, 3);
            this.TLP_Home.Controls.Add(this.pbDel, 4, 1);
            this.TLP_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Home.Location = new System.Drawing.Point(0, 0);
            this.TLP_Home.Margin = new System.Windows.Forms.Padding(0);
            this.TLP_Home.Name = "TLP_Home";
            this.TLP_Home.RowCount = 7;
            this.TLP_Home.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.TLP_Home.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TLP_Home.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TLP_Home.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TLP_Home.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TLP_Home.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.TLP_Home.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Home.Size = new System.Drawing.Size(380, 475);
            this.TLP_Home.TabIndex = 0;
            // 
            // cbSelectServer
            // 
            this.cbSelectServer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TLP_Home.SetColumnSpan(this.cbSelectServer, 3);
            this.cbSelectServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectServer.FormattingEnabled = true;
            this.cbSelectServer.Items.AddRange(new object[] {
            "brook server",
            "brook wsserver",
            "brook wssserver",
            "brook link"});
            this.cbSelectServer.Location = new System.Drawing.Point(73, 123);
            this.cbSelectServer.Name = "cbSelectServer";
            this.cbSelectServer.Size = new System.Drawing.Size(234, 25);
            this.cbSelectServer.TabIndex = 6;
            this.cbSelectServer.SelectedIndexChanged += new System.EventHandler(this.cbSelectServer_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.TLP_Home.SetColumnSpan(this.toolStrip1, 7);
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonServer,
            this.toolStripButtonRefresh,
            this.toolStripButtonSetting});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(377, 36);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip";
            // 
            // toolStripButtonServer
            // 
            this.toolStripButtonServer.AutoSize = false;
            this.toolStripButtonServer.AutoToolTip = false;
            this.toolStripButtonServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButtonServer.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripButtonServer.Image = global::BrookW.Properties.Resources.server;
            this.toolStripButtonServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonServer.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonServer.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonServer.Name = "toolStripButtonServer";
            this.toolStripButtonServer.Size = new System.Drawing.Size(75, 34);
            this.toolStripButtonServer.Text = "服务器";
            this.toolStripButtonServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonServer.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.AutoSize = false;
            this.toolStripButtonRefresh.AutoToolTip = false;
            this.toolStripButtonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButtonRefresh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brookWToolStripMenuItem,
            this.brookCoreToolStripMenuItem});
            this.toolStripButtonRefresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripButtonRefresh.Image = global::BrookW.Properties.Resources.refresh;
            this.toolStripButtonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(95, 34);
            this.toolStripButtonRefresh.Text = "检查更新";
            this.toolStripButtonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // brookWToolStripMenuItem
            // 
            this.brookWToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.brookWToolStripMenuItem.Name = "brookWToolStripMenuItem";
            this.brookWToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.brookWToolStripMenuItem.Text = "BrookW";
            // 
            // brookCoreToolStripMenuItem
            // 
            this.brookCoreToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.brookCoreToolStripMenuItem.Name = "brookCoreToolStripMenuItem";
            this.brookCoreToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.brookCoreToolStripMenuItem.Text = "Brook Core";
            this.brookCoreToolStripMenuItem.Click += new System.EventHandler(this.brookCoreToolStripMenuItem_Click);
            // 
            // toolStripButtonSetting
            // 
            this.toolStripButtonSetting.AutoSize = false;
            this.toolStripButtonSetting.AutoToolTip = false;
            this.toolStripButtonSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButtonSetting.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripButtonSetting.Image = global::BrookW.Properties.Resources.setting;
            this.toolStripButtonSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonSetting.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonSetting.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonSetting.Name = "toolStripButtonSetting";
            this.toolStripButtonSetting.Size = new System.Drawing.Size(60, 34);
            this.toolStripButtonSetting.Text = "设置";
            this.toolStripButtonSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.TLP_Home.SetColumnSpan(this.statusLabel, 3);
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.Location = new System.Drawing.Point(73, 336);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(234, 20);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "server status";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServer
            // 
            this.lblServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServer.Location = new System.Drawing.Point(70, 76);
            this.lblServer.Margin = new System.Windows.Forms.Padding(0);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(48, 20);
            this.lblServer.TabIndex = 1;
            this.lblServer.Text = "server";
            // 
            // lblView
            // 
            this.lblView.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblView.AutoSize = true;
            this.lblView.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblView.Location = new System.Drawing.Point(171, 76);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(37, 20);
            this.lblView.TabIndex = 10;
            this.lblView.TabStop = true;
            this.lblView.Text = "查看";
            this.lblView.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblView_LinkClicked);
            // 
            // panel1
            // 
            this.TLP_Home.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.pbRun);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(70, 176);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.TLP_Home.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(240, 160);
            this.panel1.TabIndex = 13;
            // 
            // pbRun
            // 
            this.pbRun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRun.BackColor = System.Drawing.Color.Transparent;
            this.pbRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRun.Location = new System.Drawing.Point(55, 25);
            this.pbRun.Margin = new System.Windows.Forms.Padding(0);
            this.pbRun.Name = "pbRun";
            this.pbRun.Size = new System.Drawing.Size(130, 130);
            this.pbRun.TabIndex = 12;
            this.pbRun.TabStop = false;
            this.pbRun.Click += new System.EventHandler(this.pbRun_Click);
            // 
            // pbDel
            // 
            this.pbDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDel.BackgroundImage = global::BrookW.Properties.Resources.del;
            this.pbDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDel.Location = new System.Drawing.Point(291, 77);
            this.pbDel.Name = "pbDel";
            this.pbDel.Size = new System.Drawing.Size(16, 16);
            this.pbDel.TabIndex = 14;
            this.pbDel.TabStop = false;
            this.pbDel.Click += new System.EventHandler(this.pbDel_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TLP_Home);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(380, 475);
            this.TLP_Home.ResumeLayout(false);
            this.TLP_Home.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TLP_Home;
        private Label lblServer;
        public ComboBox cbSelectServer;
        private ToolStrip toolStrip1;
        public ToolStripButton toolStripButtonServer;
        public ToolStripButton toolStripButtonSetting;
        public ToolStripDropDownButton toolStripButtonRefresh;
        private Label statusLabel;
        private ToolStripMenuItem brookWToolStripMenuItem;
        private ToolStripMenuItem brookCoreToolStripMenuItem;
        private LinkLabel lblView;
        private PictureBox pbRun;
        private Panel panel1;
        private PictureBox pbDel;
    }
}
