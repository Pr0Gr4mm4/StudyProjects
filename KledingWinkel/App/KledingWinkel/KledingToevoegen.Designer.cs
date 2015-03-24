namespace KledingWinkelApp
{
    partial class KledingToevoegen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddKleding = new System.Windows.Forms.Button();
            this.cBoxJasMerken = new System.Windows.Forms.ComboBox();
            this.cBoxKledingTypes = new System.Windows.Forms.ComboBox();
            this.cboxSizeTypes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKledingStukID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrijs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTshirtText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImageUrl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtImageUrl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTshirtText);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnAddKleding);
            this.groupBox1.Controls.Add(this.cBoxJasMerken);
            this.groupBox1.Controls.Add(this.cBoxKledingTypes);
            this.groupBox1.Controls.Add(this.cboxSizeTypes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtKledingStukID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrijs);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beschrijf het toe te voegen kledingstuk";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(20, 215);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Afbreken";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddKleding
            // 
            this.btnAddKleding.Location = new System.Drawing.Point(111, 215);
            this.btnAddKleding.Name = "btnAddKleding";
            this.btnAddKleding.Size = new System.Drawing.Size(121, 23);
            this.btnAddKleding.TabIndex = 1;
            this.btnAddKleding.Text = "Toevoegen";
            this.btnAddKleding.UseVisualStyleBackColor = true;
            this.btnAddKleding.Click += new System.EventHandler(this.btnAddKleding_Click);
            // 
            // cBoxJasMerken
            // 
            this.cBoxJasMerken.Enabled = false;
            this.cBoxJasMerken.FormattingEnabled = true;
            this.cBoxJasMerken.Location = new System.Drawing.Point(111, 188);
            this.cBoxJasMerken.Name = "cBoxJasMerken";
            this.cBoxJasMerken.Size = new System.Drawing.Size(121, 21);
            this.cBoxJasMerken.TabIndex = 14;
            // 
            // cBoxKledingTypes
            // 
            this.cBoxKledingTypes.FormattingEnabled = true;
            this.cBoxKledingTypes.Location = new System.Drawing.Point(111, 162);
            this.cBoxKledingTypes.Name = "cBoxKledingTypes";
            this.cBoxKledingTypes.Size = new System.Drawing.Size(121, 21);
            this.cBoxKledingTypes.TabIndex = 13;
            this.cBoxKledingTypes.SelectedIndexChanged += new System.EventHandler(this.cBoxKledingTypes_SelectedIndexChanged);
            // 
            // cboxSizeTypes
            // 
            this.cboxSizeTypes.FormattingEnabled = true;
            this.cboxSizeTypes.Location = new System.Drawing.Point(111, 136);
            this.cboxSizeTypes.Name = "cboxSizeTypes";
            this.cboxSizeTypes.Size = new System.Drawing.Size(121, 21);
            this.cboxSizeTypes.TabIndex = 12;
            this.cboxSizeTypes.SelectedIndexChanged += new System.EventHandler(this.cboxSizeTypes_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Jas type: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kleding type :";
            // 
            // txtKledingStukID
            // 
            this.txtKledingStukID.Location = new System.Drawing.Point(111, 32);
            this.txtKledingStukID.Name = "txtKledingStukID";
            this.txtKledingStukID.ReadOnly = true;
            this.txtKledingStukID.Size = new System.Drawing.Size(60, 20);
            this.txtKledingStukID.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID :";
            // 
            // txtPrijs
            // 
            this.txtPrijs.Location = new System.Drawing.Point(111, 58);
            this.txtPrijs.Name = "txtPrijs";
            this.txtPrijs.Size = new System.Drawing.Size(60, 20);
            this.txtPrijs.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prijs :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size :";
            // 
            // txtTshirtText
            // 
            this.txtTshirtText.Location = new System.Drawing.Point(111, 84);
            this.txtTshirtText.Name = "txtTshirtText";
            this.txtTshirtText.Size = new System.Drawing.Size(121, 20);
            this.txtTshirtText.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Text (Tshirt only):";
            // 
            // txtImageUrl
            // 
            this.txtImageUrl.Location = new System.Drawing.Point(111, 110);
            this.txtImageUrl.Name = "txtImageUrl";
            this.txtImageUrl.Size = new System.Drawing.Size(121, 20);
            this.txtImageUrl.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Image url :";
            // 
            // KledingToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 279);
            this.Controls.Add(this.groupBox1);
            this.Name = "KledingToevoegen";
            this.Text = "Nieuw kledingstuk toevoegen";
            this.Load += new System.EventHandler(this.KledingToevoegen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddKleding;
        private System.Windows.Forms.ComboBox cBoxJasMerken;
        private System.Windows.Forms.ComboBox cBoxKledingTypes;
        private System.Windows.Forms.ComboBox cboxSizeTypes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKledingStukID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrijs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImageUrl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTshirtText;
        private System.Windows.Forms.Label label6;
    }
}