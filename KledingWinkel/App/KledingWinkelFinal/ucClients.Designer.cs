namespace KledingWinkelFinal
{
    partial class ucClients
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblClientID = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtAddressLine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZippCode = new System.Windows.Forms.TextBox();
            this.lblZippcode = new System.Windows.Forms.Label();
            this.lblCityName = new System.Windows.Forms.Label();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(3, 6);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(47, 13);
            this.lblClientID.TabIndex = 0;
            this.lblClientID.Text = "Client ID";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(90, 3);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(62, 20);
            this.txtClientID.TabIndex = 1;
            // 
            // txtAddressLine
            // 
            this.txtAddressLine.Location = new System.Drawing.Point(90, 29);
            this.txtAddressLine.Multiline = true;
            this.txtAddressLine.Name = "txtAddressLine";
            this.txtAddressLine.Size = new System.Drawing.Size(119, 47);
            this.txtAddressLine.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Street address";
            // 
            // txtZippCode
            // 
            this.txtZippCode.Location = new System.Drawing.Point(90, 108);
            this.txtZippCode.Name = "txtZippCode";
            this.txtZippCode.Size = new System.Drawing.Size(119, 20);
            this.txtZippCode.TabIndex = 5;
            // 
            // lblZippcode
            // 
            this.lblZippcode.AutoSize = true;
            this.lblZippcode.Location = new System.Drawing.Point(3, 111);
            this.lblZippcode.Name = "lblZippcode";
            this.lblZippcode.Size = new System.Drawing.Size(56, 13);
            this.lblZippcode.TabIndex = 4;
            this.lblZippcode.Text = "Zipp Code";
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Location = new System.Drawing.Point(3, 85);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(53, 13);
            this.lblCityName.TabIndex = 4;
            this.lblCityName.Text = "City name";
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(90, 82);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(119, 20);
            this.txtCityName.TabIndex = 5;
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(90, 134);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(119, 20);
            this.txtCountryName.TabIndex = 7;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(3, 137);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(72, 13);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "Country name";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(134, 160);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(6, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Abort";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ucClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.lblCityName);
            this.Controls.Add(this.txtZippCode);
            this.Controls.Add(this.lblZippcode);
            this.Controls.Add(this.txtAddressLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.lblClientID);
            this.Name = "ucClients";
            this.Size = new System.Drawing.Size(214, 187);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtAddressLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtZippCode;
        private System.Windows.Forms.Label lblZippcode;
        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
    }
}
