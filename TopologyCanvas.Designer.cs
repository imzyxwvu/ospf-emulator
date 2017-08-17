namespace OSPF
{
    partial class TopologyCanvas
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopologyCanvas));
            this.menuDeploy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemDeploy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRouter = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeploy.SuspendLayout();
            this.menuRouter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuDeploy
            // 
            this.menuDeploy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDeploy});
            this.menuDeploy.Name = "menuDeploy";
            this.menuDeploy.Size = new System.Drawing.Size(153, 48);
            // 
            // menuItemDeploy
            // 
            this.menuItemDeploy.Image = ((System.Drawing.Image)(resources.GetObject("menuItemDeploy.Image")));
            this.menuItemDeploy.Name = "menuItemDeploy";
            this.menuItemDeploy.Size = new System.Drawing.Size(152, 22);
            this.menuItemDeploy.Text = "放置路由器(&R)";
            // 
            // menuRouter
            // 
            this.menuRouter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSearch,
            this.menuItemDelete});
            this.menuRouter.Name = "menuRouter";
            this.menuRouter.Size = new System.Drawing.Size(153, 70);
            // 
            // menuItemSearch
            // 
            this.menuItemSearch.Name = "menuItemSearch";
            this.menuItemSearch.Size = new System.Drawing.Size(152, 22);
            this.menuItemSearch.Text = "作为起点(&M)";
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("menuItemDelete.Image")));
            this.menuItemDelete.Name = "menuItemDelete";
            this.menuItemDelete.Size = new System.Drawing.Size(152, 22);
            this.menuItemDelete.Text = "删除(&D)";
            // 
            // TopologyCanvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TopologyCanvas";
            this.menuDeploy.ResumeLayout(false);
            this.menuRouter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip menuDeploy;
        private System.Windows.Forms.ToolStripMenuItem menuItemDeploy;
        private System.Windows.Forms.ContextMenuStrip menuRouter;
        private System.Windows.Forms.ToolStripMenuItem menuItemSearch;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelete;
    }
}
