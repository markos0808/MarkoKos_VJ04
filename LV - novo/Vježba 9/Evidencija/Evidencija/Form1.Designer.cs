namespace Evidencija
{
    partial class frmMain
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miData = new System.Windows.Forms.ToolStripMenuItem();
            this.miDataBrowse = new System.Windows.Forms.ToolStripMenuItem();
            this.miDataBrowseOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.miDataBrowseProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.miDataBrowseCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.miDataBrowseSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miData});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(581, 24);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(37, 20);
            this.miFile.Text = "File";
            // 
            // miFileExit
            // 
            this.miFileExit.Name = "miFileExit";
            this.miFileExit.Size = new System.Drawing.Size(152, 22);
            this.miFileExit.Text = "Exit";
            // 
            // miData
            // 
            this.miData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDataBrowse});
            this.miData.Name = "miData";
            this.miData.Size = new System.Drawing.Size(43, 20);
            this.miData.Text = "Data";
            // 
            // miDataBrowse
            // 
            this.miDataBrowse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDataBrowseOrders,
            this.miDataBrowseProducts,
            this.miDataBrowseCategories,
            this.miDataBrowseSuppliers});
            this.miDataBrowse.Name = "miDataBrowse";
            this.miDataBrowse.Size = new System.Drawing.Size(152, 22);
            this.miDataBrowse.Text = "Browse";
            // 
            // miDataBrowseOrders
            // 
            this.miDataBrowseOrders.Name = "miDataBrowseOrders";
            this.miDataBrowseOrders.Size = new System.Drawing.Size(152, 22);
            this.miDataBrowseOrders.Text = "Orders";
            this.miDataBrowseOrders.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miDataBrowseOrders_MouseUp);
            // 
            // miDataBrowseProducts
            // 
            this.miDataBrowseProducts.Name = "miDataBrowseProducts";
            this.miDataBrowseProducts.Size = new System.Drawing.Size(152, 22);
            this.miDataBrowseProducts.Text = "Products";
            // 
            // miDataBrowseCategories
            // 
            this.miDataBrowseCategories.Name = "miDataBrowseCategories";
            this.miDataBrowseCategories.Size = new System.Drawing.Size(152, 22);
            this.miDataBrowseCategories.Text = "Categories";
            // 
            // miDataBrowseSuppliers
            // 
            this.miDataBrowseSuppliers.Name = "miDataBrowseSuppliers";
            this.miDataBrowseSuppliers.Size = new System.Drawing.Size(152, 22);
            this.miDataBrowseSuppliers.Text = "Suppliers";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 346);
            this.Controls.Add(this.msMain);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACME d.o.o.";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miFileExit;
        private System.Windows.Forms.ToolStripMenuItem miData;
        private System.Windows.Forms.ToolStripMenuItem miDataBrowse;
        private System.Windows.Forms.ToolStripMenuItem miDataBrowseOrders;
        private System.Windows.Forms.ToolStripMenuItem miDataBrowseProducts;
        private System.Windows.Forms.ToolStripMenuItem miDataBrowseCategories;
        private System.Windows.Forms.ToolStripMenuItem miDataBrowseSuppliers;
    }
}

