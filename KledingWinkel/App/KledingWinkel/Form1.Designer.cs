namespace KledingWinkelApp
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKledingStukToevoegen = new System.Windows.Forms.Button();
            this.btnTestSqlConnection = new System.Windows.Forms.Button();
            this.txtUserOutPutTest = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.mainToolStripMenuItem.Text = "&Main";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // btnKledingStukToevoegen
            // 
            this.btnKledingStukToevoegen.Location = new System.Drawing.Point(13, 28);
            this.btnKledingStukToevoegen.Name = "btnKledingStukToevoegen";
            this.btnKledingStukToevoegen.Size = new System.Drawing.Size(142, 118);
            this.btnKledingStukToevoegen.TabIndex = 1;
            this.btnKledingStukToevoegen.Text = "Kledingstuk toevoegen";
            this.btnKledingStukToevoegen.UseVisualStyleBackColor = true;
            this.btnKledingStukToevoegen.Click += new System.EventHandler(this.btnKledingStukToevoegen_Click);
            // 
            // btnTestSqlConnection
            // 
            this.btnTestSqlConnection.Location = new System.Drawing.Point(383, 94);
            this.btnTestSqlConnection.Name = "btnTestSqlConnection";
            this.btnTestSqlConnection.Size = new System.Drawing.Size(208, 155);
            this.btnTestSqlConnection.TabIndex = 2;
            this.btnTestSqlConnection.Text = "Test sql connection";
            this.btnTestSqlConnection.UseVisualStyleBackColor = true;
            this.btnTestSqlConnection.Click += new System.EventHandler(this.btnTestSqlConnection_Click);
            // 
            // txtUserOutPutTest
            // 
            this.txtUserOutPutTest.Location = new System.Drawing.Point(154, 211);
            this.txtUserOutPutTest.Multiline = true;
            this.txtUserOutPutTest.Name = "txtUserOutPutTest";
            this.txtUserOutPutTest.Size = new System.Drawing.Size(212, 160);
            this.txtUserOutPutTest.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(243, 71);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(196, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 416);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUserOutPutTest);
            this.Controls.Add(this.btnTestSqlConnection);
            this.Controls.Add(this.btnKledingStukToevoegen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Kleding winkel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnKledingStukToevoegen;
        private System.Windows.Forms.Button btnTestSqlConnection;
        private System.Windows.Forms.TextBox txtUserOutPutTest;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

