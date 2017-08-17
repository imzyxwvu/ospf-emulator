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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OSPFEditor));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tscbSpeed = new System.Windows.Forms.ToolStripComboBox();
            this.tsbDeployLine = new System.Windows.Forms.ToolStripButton();
            this.menuRouter = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeploy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemDeploy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuRouter.SuspendLayout();
            this.menuDeploy.SuspendLayout();
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
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbSpeed,
            this.tsbDeployLine});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
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
            // menuRouter
            // 
            this.menuRouter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSearch,
            this.menuItemDelete});
            this.menuRouter.Name = "menuRouter";
            this.menuRouter.Size = new System.Drawing.Size(137, 48);
            // 
            // menuItemSearch
            // 
            this.menuItemSearch.Name = "menuItemSearch";
            this.menuItemSearch.Size = new System.Drawing.Size(136, 22);
            this.menuItemSearch.Text = "作为起点(&M)";
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("menuItemDelete.Image")));
            this.menuItemDelete.Name = "menuItemDelete";
            this.menuItemDelete.Size = new System.Drawing.Size(136, 22);
            this.menuItemDelete.Text = "删除(&D)";
            // 
            // menuDeploy
            // 
            this.menuDeploy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDeploy});
            this.menuDeploy.Name = "menuDeploy";
            this.menuDeploy.Size = new System.Drawing.Size(149, 26);
            // 
            // menuItemDeploy
            // 
            this.menuItemDeploy.Image = ((System.Drawing.Image)(resources.GetObject("menuItemDeploy.Image")));
            this.menuItemDeploy.Name = "menuItemDeploy";
            this.menuItemDeploy.Size = new System.Drawing.Size(148, 22);
            this.menuItemDeploy.Text = "放置路由器(&R)";
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
            this.menuRouter.ResumeLayout(false);
            this.menuDeploy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox tscbSpeed;
        private System.Windows.Forms.ToolStripButton tsbDeployLine;
        private System.Windows.Forms.ContextMenuStrip menuRouter;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelete;
        private System.Windows.Forms.ContextMenuStrip menuDeploy;
        private System.Windows.Forms.ToolStripMenuItem menuItemDeploy;
        private System.Windows.Forms.ToolStripMenuItem menuItemSearch;

    }
}

