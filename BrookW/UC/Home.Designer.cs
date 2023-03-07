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
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonServer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripDropDownButton();
            this.brookWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brookCoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonSetting = new System.Windows.Forms.ToolStripButton();
            this.statusLabel = new System.Windows.Forms.Label();
            this.TLP_Home.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLP_Home
            // 
            this.TLP_Home.ColumnCount = 5;
            this.TLP_Home.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TLP_Home.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Home.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.TLP_Home.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Home.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TLP_Home.Controls.Add(this.cbSelectServer, 2, 2);
            this.TLP_Home.Controls.Add(this.label1, 0, 2);
            this.TLP_Home.Controls.Add(this.toolStrip1, 0, 0);
            this.TLP_Home.Controls.Add(this.statusLabel, 2, 5);
            this.TLP_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Home.Location = new System.Drawing.Point(0, 0);
            this.TLP_Home.Name = "TLP_Home";
            this.TLP_Home.RowCount = 6;
            this.TLP_Home.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.TLP_Home.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TLP_Home.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLP_Home.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLP_Home.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLP_Home.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Home.Size = new System.Drawing.Size(380, 475);
            this.TLP_Home.TabIndex = 0;
            // 
            // cbSelectServer
            // 
            this.cbSelectServer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbSelectServer.FormattingEnabled = true;
            this.cbSelectServer.Items.AddRange(new object[] {
            "brook server",
            "brook wsserver",
            "brook wssserver",
            "brook link"});
            this.cbSelectServer.Location = new System.Drawing.Point(88, 148);
            this.cbSelectServer.Name = "cbSelectServer";
            this.cbSelectServer.Size = new System.Drawing.Size(234, 25);
            this.cbSelectServer.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.TLP_Home.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(20, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "wssserver";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.TLP_Home.SetColumnSpan(this.toolStrip1, 5);
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripButtonServer,
            this.toolStripButtonRefresh,
            this.toolStripButtonSetting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(380, 36);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
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
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // brookWToolStripMenuItem
            // 
            this.brookWToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.brookWToolStripMenuItem.Name = "brookWToolStripMenuItem";
            this.brookWToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.brookWToolStripMenuItem.Text = "BrookW";
            // 
            // brookCoreToolStripMenuItem
            // 
            this.brookCoreToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.brookCoreToolStripMenuItem.Name = "brookCoreToolStripMenuItem";
            this.brookCoreToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.brookCoreToolStripMenuItem.Text = "Brook Core";
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
            this.statusLabel.Location = new System.Drawing.Point(88, 286);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 17);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "label2";
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
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TLP_Home;
        private Label label1;
        public ComboBox cbSelectServer;
        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator1;
        public ToolStripButton toolStripButtonServer;
        public ToolStripButton toolStripButtonSetting;
        public ToolStripDropDownButton toolStripButtonRefresh;
        private Label statusLabel;
        private ToolStripMenuItem brookWToolStripMenuItem;
        private ToolStripMenuItem brookCoreToolStripMenuItem;
    }
}
