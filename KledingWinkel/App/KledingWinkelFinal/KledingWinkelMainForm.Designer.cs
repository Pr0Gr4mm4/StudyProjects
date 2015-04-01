namespace KledingWinkelFinal
{
    partial class KledingWinkelMainForm
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overviewClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editExistingClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overviewProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editExistingProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overviewOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editExistingOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(802, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeCloseToolStripMenuItem,
            this.closeAllWindowsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.mainToolStripMenuItem.Text = "&Main";
            // 
            // cascadeCloseToolStripMenuItem
            // 
            this.cascadeCloseToolStripMenuItem.Name = "cascadeCloseToolStripMenuItem";
            this.cascadeCloseToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.cascadeCloseToolStripMenuItem.Text = "&Cascade Close Windows";
            this.cascadeCloseToolStripMenuItem.Click += new System.EventHandler(this.cascadeCloseToolStripMenuItem_Click);
            // 
            // closeAllWindowsToolStripMenuItem
            // 
            this.closeAllWindowsToolStripMenuItem.Name = "closeAllWindowsToolStripMenuItem";
            this.closeAllWindowsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.closeAllWindowsToolStripMenuItem.Text = "Close &All Windows";
            this.closeAllWindowsToolStripMenuItem.Click += new System.EventHandler(this.closeAllWindowsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overviewClientsToolStripMenuItem,
            this.addNewClientToolStripMenuItem,
            this.editExistingClientToolStripMenuItem,
            this.removeClientToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.clientsToolStripMenuItem.Text = "&Clients";
            // 
            // overviewClientsToolStripMenuItem
            // 
            this.overviewClientsToolStripMenuItem.Name = "overviewClientsToolStripMenuItem";
            this.overviewClientsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.overviewClientsToolStripMenuItem.Text = "&Overview clients";
            this.overviewClientsToolStripMenuItem.Click += new System.EventHandler(this.overviewClientsToolStripMenuItem_Click);
            // 
            // addNewClientToolStripMenuItem
            // 
            this.addNewClientToolStripMenuItem.Name = "addNewClientToolStripMenuItem";
            this.addNewClientToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addNewClientToolStripMenuItem.Text = "&Add new client";
            this.addNewClientToolStripMenuItem.Click += new System.EventHandler(this.addNewClientToolStripMenuItem_Click);
            // 
            // editExistingClientToolStripMenuItem
            // 
            this.editExistingClientToolStripMenuItem.Name = "editExistingClientToolStripMenuItem";
            this.editExistingClientToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.editExistingClientToolStripMenuItem.Text = "&Edit existing client";
            // 
            // removeClientToolStripMenuItem
            // 
            this.removeClientToolStripMenuItem.Name = "removeClientToolStripMenuItem";
            this.removeClientToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.removeClientToolStripMenuItem.Text = "&Remove client";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overviewProductsToolStripMenuItem,
            this.addNewProductToolStripMenuItem,
            this.editExistingProductToolStripMenuItem,
            this.removeProductToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productsToolStripMenuItem.Text = "&Products";
            // 
            // overviewProductsToolStripMenuItem
            // 
            this.overviewProductsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inDatabaseToolStripMenuItem,
            this.forSaleToolStripMenuItem});
            this.overviewProductsToolStripMenuItem.Name = "overviewProductsToolStripMenuItem";
            this.overviewProductsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.overviewProductsToolStripMenuItem.Text = "&Overview products";
            // 
            // inDatabaseToolStripMenuItem
            // 
            this.inDatabaseToolStripMenuItem.Name = "inDatabaseToolStripMenuItem";
            this.inDatabaseToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.inDatabaseToolStripMenuItem.Text = "&In Database";
            this.inDatabaseToolStripMenuItem.Click += new System.EventHandler(this.inDatabaseToolStripMenuItem_Click);
            // 
            // forSaleToolStripMenuItem
            // 
            this.forSaleToolStripMenuItem.Name = "forSaleToolStripMenuItem";
            this.forSaleToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.forSaleToolStripMenuItem.Text = "&For Sale";
            this.forSaleToolStripMenuItem.Click += new System.EventHandler(this.forSaleToolStripMenuItem_Click);
            // 
            // addNewProductToolStripMenuItem
            // 
            this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addNewProductToolStripMenuItem.Text = "&Add new product";
            // 
            // editExistingProductToolStripMenuItem
            // 
            this.editExistingProductToolStripMenuItem.Name = "editExistingProductToolStripMenuItem";
            this.editExistingProductToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.editExistingProductToolStripMenuItem.Text = "&Edit existing product";
            // 
            // removeProductToolStripMenuItem
            // 
            this.removeProductToolStripMenuItem.Name = "removeProductToolStripMenuItem";
            this.removeProductToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.removeProductToolStripMenuItem.Text = "&Remove product";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overviewOrdersToolStripMenuItem,
            this.toolStripMenuItem2,
            this.editExistingOrderToolStripMenuItem,
            this.removeOrderToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ordersToolStripMenuItem.Text = "&Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // overviewOrdersToolStripMenuItem
            // 
            this.overviewOrdersToolStripMenuItem.Name = "overviewOrdersToolStripMenuItem";
            this.overviewOrdersToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.overviewOrdersToolStripMenuItem.Text = "&Overview orders";
            this.overviewOrdersToolStripMenuItem.Click += new System.EventHandler(this.overviewOrdersToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem2.Text = "&Add new order";
            // 
            // editExistingOrderToolStripMenuItem
            // 
            this.editExistingOrderToolStripMenuItem.Name = "editExistingOrderToolStripMenuItem";
            this.editExistingOrderToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.editExistingOrderToolStripMenuItem.Text = "&Edit existing order";
            // 
            // removeOrderToolStripMenuItem
            // 
            this.removeOrderToolStripMenuItem.Name = "removeOrderToolStripMenuItem";
            this.removeOrderToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.removeOrderToolStripMenuItem.Text = "&Remove order";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.aboutToolStripMenuItem1.Text = "&Version";
            // 
            // KledingWinkelMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 411);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "KledingWinkelMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clothes Store - Made by \'MrSyntax\' Tom de Haan";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overviewClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editExistingClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overviewProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editExistingProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overviewOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editExistingOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cascadeCloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forSaleToolStripMenuItem;
    }
}

