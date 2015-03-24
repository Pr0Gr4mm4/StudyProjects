namespace KledingWinkelFinal
{
    partial class ObjectManipulationForm
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
            this.objectManipulationContainer = new System.Windows.Forms.TabControl();
            this.tabClientManipulation = new System.Windows.Forms.TabPage();
            this.tabProductManipulation = new System.Windows.Forms.TabPage();
            this.tabOrderManipulation = new System.Windows.Forms.TabPage();
            this.tabOrderItemManipulation = new System.Windows.Forms.TabPage();
            this.objectManipulationContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // objectManipulationContainer
            // 
            this.objectManipulationContainer.Controls.Add(this.tabClientManipulation);
            this.objectManipulationContainer.Controls.Add(this.tabProductManipulation);
            this.objectManipulationContainer.Controls.Add(this.tabOrderManipulation);
            this.objectManipulationContainer.Controls.Add(this.tabOrderItemManipulation);
            this.objectManipulationContainer.Location = new System.Drawing.Point(1, 1);
            this.objectManipulationContainer.Name = "objectManipulationContainer";
            this.objectManipulationContainer.SelectedIndex = 0;
            this.objectManipulationContainer.Size = new System.Drawing.Size(386, 300);
            this.objectManipulationContainer.TabIndex = 0;
            // 
            // tabClientManipulation
            // 
            this.tabClientManipulation.Location = new System.Drawing.Point(4, 22);
            this.tabClientManipulation.Name = "tabClientManipulation";
            this.tabClientManipulation.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientManipulation.Size = new System.Drawing.Size(378, 274);
            this.tabClientManipulation.TabIndex = 0;
            this.tabClientManipulation.Text = "Client";
            this.tabClientManipulation.UseVisualStyleBackColor = true;
            this.tabClientManipulation.Click += new System.EventHandler(this.tabClientManipulation_Click);
            // 
            // tabProductManipulation
            // 
            this.tabProductManipulation.Location = new System.Drawing.Point(4, 22);
            this.tabProductManipulation.Name = "tabProductManipulation";
            this.tabProductManipulation.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductManipulation.Size = new System.Drawing.Size(378, 274);
            this.tabProductManipulation.TabIndex = 1;
            this.tabProductManipulation.Text = "Product";
            this.tabProductManipulation.UseVisualStyleBackColor = true;
            // 
            // tabOrderManipulation
            // 
            this.tabOrderManipulation.Location = new System.Drawing.Point(4, 22);
            this.tabOrderManipulation.Name = "tabOrderManipulation";
            this.tabOrderManipulation.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrderManipulation.Size = new System.Drawing.Size(378, 274);
            this.tabOrderManipulation.TabIndex = 2;
            this.tabOrderManipulation.Text = "Order";
            this.tabOrderManipulation.UseVisualStyleBackColor = true;
            // 
            // tabOrderItemManipulation
            // 
            this.tabOrderItemManipulation.Location = new System.Drawing.Point(4, 22);
            this.tabOrderItemManipulation.Name = "tabOrderItemManipulation";
            this.tabOrderItemManipulation.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrderItemManipulation.Size = new System.Drawing.Size(378, 274);
            this.tabOrderItemManipulation.TabIndex = 3;
            this.tabOrderItemManipulation.Text = "OrderItem";
            this.tabOrderItemManipulation.UseVisualStyleBackColor = true;
            // 
            // ObjectManipulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 388);
            this.Controls.Add(this.objectManipulationContainer);
            this.Name = "ObjectManipulationForm";
            this.Text = "ObjectManipulationForm";
            this.Load += new System.EventHandler(this.ObjectManipulationForm_Load);
            this.objectManipulationContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl objectManipulationContainer;
        private System.Windows.Forms.TabPage tabClientManipulation;
        private System.Windows.Forms.TabPage tabProductManipulation;
        private System.Windows.Forms.TabPage tabOrderManipulation;
        private System.Windows.Forms.TabPage tabOrderItemManipulation;
    }
}