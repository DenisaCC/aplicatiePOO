namespace POO
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkShowPsw = new System.Windows.Forms.CheckBox();
            this.btnIesire = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginParola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoginUtilizator = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.checkShowPsw);
            this.panel1.Controls.Add(this.btnIesire);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtLoginParola);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtLoginUtilizator);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 485);
            this.panel1.TabIndex = 0;
            // 
            // checkShowPsw
            // 
            this.checkShowPsw.AutoSize = true;
            this.checkShowPsw.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkShowPsw.Location = new System.Drawing.Point(335, 254);
            this.checkShowPsw.Name = "checkShowPsw";
            this.checkShowPsw.Size = new System.Drawing.Size(135, 23);
            this.checkShowPsw.TabIndex = 6;
            this.checkShowPsw.Text = "Show password";
            this.checkShowPsw.UseVisualStyleBackColor = true;
            this.checkShowPsw.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnIesire
            // 
            this.btnIesire.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnIesire.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIesire.BackgroundImage")));
            this.btnIesire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIesire.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIesire.Location = new System.Drawing.Point(8, 14);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(112, 40);
            this.btnIesire.TabIndex = 5;
            this.btnIesire.Text = "Ieșire";
            this.btnIesire.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIesire.UseVisualStyleBackColor = false;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLogin.Location = new System.Drawing.Point(180, 354);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(156, 55);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLoginParola
            // 
            this.txtLoginParola.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLoginParola.Location = new System.Drawing.Point(211, 203);
            this.txtLoginParola.Name = "txtLoginParola";
            this.txtLoginParola.Size = new System.Drawing.Size(259, 34);
            this.txtLoginParola.TabIndex = 3;
            this.txtLoginParola.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(32, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola:";
            // 
            // txtLoginUtilizator
            // 
            this.txtLoginUtilizator.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLoginUtilizator.Location = new System.Drawing.Point(211, 110);
            this.txtLoginUtilizator.Name = "txtLoginUtilizator";
            this.txtLoginUtilizator.Size = new System.Drawing.Size(259, 34);
            this.txtLoginUtilizator.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume Utilizator:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 595);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkShowPsw;
        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLoginParola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginUtilizator;
        private System.Windows.Forms.Label label1;
    }
}