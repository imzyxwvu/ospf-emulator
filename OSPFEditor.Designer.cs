namespace OSPF
{
    partial class OSPFEditor
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OSPFEditor));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tscbSpeed = new System.Windows.Forms.ToolStripComboBox();
            this.tsbDeployLine = new System.Windows.Forms.ToolStripButton();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbDeployRouter = new System.Windows.Forms.ToolStripButton();
            this.tsbDoSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteRouter = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(692, 495);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(692, 520);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.mainToolStrip);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbSpeed,
            this.tsbDeployLine});
            this.toolStrip1.Location = new System.Drawing.Point(236, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(225, 25);
            this.toolStrip1.TabIndex = 1;
            // 
            // tscbSpeed
            // 
            this.tscbSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbSpeed.Items.AddRange(new object[] {
            "Ethernet",
            "FastEthernet",
            "GigabitEthernet",
            "TenGigabitEthernet"});
            this.tscbSpeed.Name = "tscbSpeed";
            this.tscbSpeed.Size = new System.Drawing.Size(121, 25);
            // 
            // tsbDeployLine
            // 
            this.tsbDeployLine.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeployLine.Image")));
            this.tsbDeployLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeployLine.Name = "tsbDeployLine";
            this.tsbDeployLine.Size = new System.Drawing.Size(61, 22);
            this.tsbDeployLine.Text = "拉网线";
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDeployRouter,
            this.tsbDoSearch,
            this.tsbDeleteRouter});
            this.mainToolStrip.Location = new System.Drawing.Point(3, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(217, 25);
            this.mainToolStrip.TabIndex = 0;
            // 
            // tsbDeployRouter
            // 
            this.tsbDeployRouter.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeployRouter.Image")));
            this.tsbDeployRouter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeployRouter.Name = "tsbDeployRouter";
            this.tsbDeployRouter.Size = new System.Drawing.Size(85, 22);
            this.tsbDeployRouter.Text = "放置路由器";
            // 
            // tsbDoSearch
            // 
            this.tsbDoSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbDoSearch.Image")));
            this.tsbDoSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDoSearch.Name = "tsbDoSearch";
            this.tsbDoSearch.Size = new System.Drawing.Size(73, 22);
            this.tsbDoSearch.Text = "搜索路径";
            // 
            // tsbDeleteRouter
            // 
            this.tsbDeleteRouter.Enabled = false;
            this.tsbDeleteRouter.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteRouter.Image")));
            this.tsbDeleteRouter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteRouter.Name = "tsbDeleteRouter";
            this.tsbDeleteRouter.Size = new System.Drawing.Size(49, 22);
            this.tsbDeleteRouter.Text = "删除";
            // 
            // OSPFEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 520);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "OSPFEditor";
            this.Text = "OSPF Emulator";
            this.Load += new System.EventHandler(this.OSPFEditor_Load);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton tsbDeployRouter;
        private System.Windows.Forms.ToolStripButton tsbDeleteRouter;
        private System.Windows.Forms.ToolStripButton tsbDoSearch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox tscbSpeed;
        private System.Windows.Forms.ToolStripButton tsbDeployLine;

    }
}

