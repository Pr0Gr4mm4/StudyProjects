namespace KledingWinkelFinal
{
    partial class ObjectOverviewForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeCloseWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeOverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overviewGridview = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnOverviewAllLinkedToSelected = new System.Windows.Forms.Button();
            this.btnOverviewSelected = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.btnUpdateSelected = new System.Windows.Forms.Button();
            this.btnReadSpecific = new System.Windows.Forms.Button();
            this.btnCreateNew = new System.Windows.Forms.Button();
            //this.kledingWinkelDataSet = new KledingWinkelFinal.KledingWinkelDataSet();
            //this.overviewOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.overviewOrdersTableAdapter = new KledingWinkelFinal.KledingWinkelDataSetTableAdapters.OverviewOrdersTableAdapter();
            //this.overviewClothesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.overviewClothesTableAdapter = new KledingWinkelFinal.KledingWinkelDataSetTableAdapters.OverviewClothesTableAdapter();
            //this.overviewCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.overviewCustomersTableAdapter = new KledingWinkelFinal.KledingWinkelDataSetTableAdapters.OverviewCustomersTableAdapter();
            //this.overviewStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.overviewStockTableAdapter = new KledingWinkelFinal.KledingWinkelDataSetTableAdapters.OverviewStockTableAdapter();
            //this.overviewOrderItemDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.overviewOrderItemDetailsTableAdapter = new KledingWinkelFinal.KledingWinkelDataSetTableAdapters.OverviewOrderItemDetailsTableAdapter();
            //this.kledingWinkelDataSet1 = new KledingWinkelFinal.KledingWinkelDataSet1();
            //this.kledingWinkelDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overviewGridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.kledingWinkelDataSet)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.overviewOrdersBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.overviewClothesBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.overviewCustomersBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.overviewStockBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.overviewOrderItemDetailsBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.kledingWinkelDataSet1)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.kledingWinkelDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeCloseWindowsToolStripMenuItem,
            this.closeOverviewToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.mainToolStripMenuItem.Text = "&Menu";
            // 
            // cascadeCloseWindowsToolStripMenuItem
            // 
            this.cascadeCloseWindowsToolStripMenuItem.Name = "cascadeCloseWindowsToolStripMenuItem";
            this.cascadeCloseWindowsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.cascadeCloseWindowsToolStripMenuItem.Text = "&Cascade close windows";
            // 
            // closeOverviewToolStripMenuItem
            // 
            this.closeOverviewToolStripMenuItem.Name = "closeOverviewToolStripMenuItem";
            this.closeOverviewToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.closeOverviewToolStripMenuItem.Text = "Close &Overview";
            this.closeOverviewToolStripMenuItem.Click += new System.EventHandler(this.closeOverviewToolStripMenuItem_Click);
            // 
            // overviewGridview
            // 
            this.overviewGridview.AllowUserToAddRows = false;
            this.overviewGridview.AllowUserToDeleteRows = false;
            this.overviewGridview.AutoGenerateColumns = false;
            this.overviewGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //this.overviewGridview.DataSource = this.kledingWinkelDataSet1BindingSource;
            this.overviewGridview.Location = new System.Drawing.Point(6, 19);
            this.overviewGridview.Name = "overviewGridview";
            this.overviewGridview.ReadOnly = true;
            this.overviewGridview.Size = new System.Drawing.Size(597, 278);
            this.overviewGridview.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.overviewGridview);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 303);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overview";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(629, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 303);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Overview manipulation";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnOverviewAllLinkedToSelected);
            this.groupBox4.Controls.Add(this.btnOverviewSelected);
            this.groupBox4.Location = new System.Drawing.Point(7, 164);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(122, 98);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Query commands";
            // 
            // btnOverviewAllLinkedToSelected
            // 
            this.btnOverviewAllLinkedToSelected.Location = new System.Drawing.Point(6, 49);
            this.btnOverviewAllLinkedToSelected.Name = "btnOverviewAllLinkedToSelected";
            this.btnOverviewAllLinkedToSelected.Size = new System.Drawing.Size(110, 39);
            this.btnOverviewAllLinkedToSelected.TabIndex = 5;
            this.btnOverviewAllLinkedToSelected.Text = "Overview all linked to selected";
            this.btnOverviewAllLinkedToSelected.UseVisualStyleBackColor = true;
            // 
            // btnOverviewSelected
            // 
            this.btnOverviewSelected.Location = new System.Drawing.Point(6, 19);
            this.btnOverviewSelected.Name = "btnOverviewSelected";
            this.btnOverviewSelected.Size = new System.Drawing.Size(110, 23);
            this.btnOverviewSelected.TabIndex = 4;
            this.btnOverviewSelected.Text = "Overview selected";
            this.btnOverviewSelected.UseVisualStyleBackColor = true;
            this.btnOverviewSelected.Click += new System.EventHandler(this.btnOverviewSelected_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRemoveSelected);
            this.groupBox3.Controls.Add(this.btnUpdateSelected);
            this.groupBox3.Controls.Add(this.btnReadSpecific);
            this.groupBox3.Controls.Add(this.btnCreateNew);
            this.groupBox3.Location = new System.Drawing.Point(7, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 138);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CRUD commands";
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(6, 106);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(110, 23);
            this.btnRemoveSelected.TabIndex = 3;
            this.btnRemoveSelected.Text = "Remove selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSelected
            // 
            this.btnUpdateSelected.Location = new System.Drawing.Point(6, 77);
            this.btnUpdateSelected.Name = "btnUpdateSelected";
            this.btnUpdateSelected.Size = new System.Drawing.Size(110, 23);
            this.btnUpdateSelected.TabIndex = 2;
            this.btnUpdateSelected.Text = "Update selected";
            this.btnUpdateSelected.UseVisualStyleBackColor = true;
            // 
            // btnReadSpecific
            // 
            this.btnReadSpecific.Location = new System.Drawing.Point(6, 48);
            this.btnReadSpecific.Name = "btnReadSpecific";
            this.btnReadSpecific.Size = new System.Drawing.Size(110, 23);
            this.btnReadSpecific.TabIndex = 1;
            this.btnReadSpecific.Text = "Read specific..";
            this.btnReadSpecific.UseVisualStyleBackColor = true;
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(6, 19);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(110, 23);
            this.btnCreateNew.TabIndex = 0;
            this.btnCreateNew.Text = "Create new";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            // 
            //// kledingWinkelDataSet
            //// 
            //this.kledingWinkelDataSet.DataSetName = "KledingWinkelDataSet";
            //this.kledingWinkelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            //// 
            //// overviewOrdersBindingSource
            //// 
            //this.overviewOrdersBindingSource.DataMember = "OverviewOrders";
            //this.overviewOrdersBindingSource.DataSource = this.kledingWinkelDataSet;
            //// 
            //// overviewOrdersTableAdapter
            //// 
            //this.overviewOrdersTableAdapter.ClearBeforeFill = true;
            //// 
            //// overviewClothesBindingSource
            //// 
            //this.overviewClothesBindingSource.DataMember = "OverviewClothes";
            //this.overviewClothesBindingSource.DataSource = this.kledingWinkelDataSet;
            //// 
            //// overviewClothesTableAdapter
            //// 
            //this.overviewClothesTableAdapter.ClearBeforeFill = true;
            //// 
            //// overviewCustomersBindingSource
            //// 
            //this.overviewCustomersBindingSource.DataMember = "OverviewCustomers";
            //this.overviewCustomersBindingSource.DataSource = this.kledingWinkelDataSet;
            //// 
            //// overviewCustomersTableAdapter
            //// 
            //this.overviewCustomersTableAdapter.ClearBeforeFill = true;
            //// 
            //// overviewStockBindingSource
            //// 
            //this.overviewStockBindingSource.DataMember = "OverviewStock";
            //this.overviewStockBindingSource.DataSource = this.kledingWinkelDataSet;
            //// 
            //// overviewStockTableAdapter
            //// 
            //this.overviewStockTableAdapter.ClearBeforeFill = true;
            //// 
            //// overviewOrderItemDetailsBindingSource
            //// 
            //this.overviewOrderItemDetailsBindingSource.DataMember = "OverviewOrderItemDetails";
            //this.overviewOrderItemDetailsBindingSource.DataSource = this.kledingWinkelDataSet;
            //// 
            //// overviewOrderItemDetailsTableAdapter
            //// 
            //this.overviewOrderItemDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // kledingWinkelDataSet1
            // 
            //this.kledingWinkelDataSet1.DataSetName = "KledingWinkelDataSet1";
            //this.kledingWinkelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kledingWinkelDataSet1BindingSource
            // 
            //this.kledingWinkelDataSet1BindingSource.DataSource = this.kledingWinkelDataSet1;
            //this.kledingWinkelDataSet1BindingSource.Position = 0;
            // 
            // ObjectOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 341);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ObjectOverviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Overview: [Clients/Products/Orders]";
            this.Load += new System.EventHandler(this.ObjectOverviewForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overviewGridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            //((System.ComponentModel.ISupportInitialize)(this.kledingWinkelDataSet)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.overviewOrdersBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.overviewClothesBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.overviewCustomersBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.overviewStockBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.overviewOrderItemDetailsBindingSource)).EndInit();
            ////((System.ComponentModel.ISupportInitialize)(this.kledingWinkelDataSet1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.kledingWinkelDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeCloseWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeOverviewToolStripMenuItem;
        private System.Windows.Forms.DataGridView overviewGridview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnOverviewAllLinkedToSelected;
        private System.Windows.Forms.Button btnOverviewSelected;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Button btnUpdateSelected;
        private System.Windows.Forms.Button btnReadSpecific;
        private System.Windows.Forms.Button btnCreateNew;
        //private KledingWinkelDataSet kledingWinkelDataSet;
        //private System.Windows.Forms.BindingSource overviewOrdersBindingSource;
        ////private KledingWinkelDataSetTableAdapters.OverviewOrdersTableAdapter overviewOrdersTableAdapter;
        //private System.Windows.Forms.BindingSource overviewClothesBindingSource;
        ////private KledingWinkelDataSetTableAdapters.OverviewClothesTableAdapter overviewClothesTableAdapter;
        //private System.Windows.Forms.BindingSource overviewCustomersBindingSource;
        ////private KledingWinkelDataSetTableAdapters.OverviewCustomersTableAdapter overviewCustomersTableAdapter;
        //private System.Windows.Forms.BindingSource overviewStockBindingSource;
        ////private KledingWinkelDataSetTableAdapters.OverviewStockTableAdapter overviewStockTableAdapter;
        //private System.Windows.Forms.BindingSource overviewOrderItemDetailsBindingSource;
        ////private KledingWinkelDataSetTableAdapters.OverviewOrderItemDetailsTableAdapter overviewOrderItemDetailsTableAdapter;
        //private System.Windows.Forms.BindingSource kledingWinkelDataSet1BindingSource;
        //private KledingWinkelDataSetOld kledingWinkelDataSet;
        //private KledingWinkelDataSetTableAdapters.OverviewClothesTableAdapter overviewClothesTableAdapter;
        //private System.Windows.Forms.BindingSource overviewCustomersBindingSource;
        //private KledingWinkelDataSetTableAdapters.OverviewCustomersTableAdapter overviewCustomersTableAdapter;
        //private System.Windows.Forms.BindingSource overviewOrdersBindingSource;
        //private KledingWinkelDataSetTableAdapters.OverviewOrdersTableAdapter overviewOrdersTableAdapter;
        //private System.Windows.Forms.BindingSource overviewStockBindingSource;
        //private KledingWinkelDataSetTableAdapters.OverviewStockTableAdapter overviewStockTableAdapter;
    }
}