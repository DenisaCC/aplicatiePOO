namespace POO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnZboruri = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnPasageri = new System.Windows.Forms.Button();
            this.btnServicii = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdmin.BackgroundImage")));
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdmin.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdmin.Location = new System.Drawing.Point(25, 15);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(248, 57);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Administrare";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogout.Location = new System.Drawing.Point(1002, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(187, 57);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnZboruri
            // 
            this.btnZboruri.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnZboruri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZboruri.BackgroundImage")));
            this.btnZboruri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnZboruri.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZboruri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZboruri.Location = new System.Drawing.Point(40, 170);
            this.btnZboruri.Name = "btnZboruri";
            this.btnZboruri.Size = new System.Drawing.Size(254, 62);
            this.btnZboruri.TabIndex = 2;
            this.btnZboruri.Text = "Program zboruri";
            this.btnZboruri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZboruri.UseVisualStyleBackColor = false;
            this.btnZboruri.Click += new System.EventHandler(this.btnZboruri_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPersonal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersonal.BackgroundImage")));
            this.btnPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPersonal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPersonal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPersonal.Location = new System.Drawing.Point(40, 357);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(247, 57);
            this.btnPersonal.TabIndex = 3;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.UseVisualStyleBackColor = false;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnPasageri
            // 
            this.btnPasageri.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPasageri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPasageri.BackgroundImage")));
            this.btnPasageri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPasageri.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPasageri.Location = new System.Drawing.Point(548, 170);
            this.btnPasageri.Name = "btnPasageri";
            this.btnPasageri.Size = new System.Drawing.Size(247, 62);
            this.btnPasageri.TabIndex = 4;
            this.btnPasageri.Text = "Pasageri";
            this.btnPasageri.UseVisualStyleBackColor = false;
            this.btnPasageri.Click += new System.EventHandler(this.btnPasageri_Click);
            // 
            // btnServicii
            // 
            this.btnServicii.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnServicii.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnServicii.BackgroundImage")));
            this.btnServicii.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnServicii.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnServicii.Location = new System.Drawing.Point(548, 357);
            this.btnServicii.Name = "btnServicii";
            this.btnServicii.Size = new System.Drawing.Size(247, 57);
            this.btnServicii.TabIndex = 5;
            this.btnServicii.Text = "Servicii";
            this.btnServicii.UseVisualStyleBackColor = false;
            this.btnServicii.Click += new System.EventHandler(this.btnServicii_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnServicii);
            this.panel1.Controls.Add(this.btnPasageri);
            this.panel1.Controls.Add(this.btnPersonal);
            this.panel1.Controls.Add(this.btnZboruri);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 548);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 642);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aeroport";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnZboruri;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Button btnPasageri;
        private System.Windows.Forms.Button btnServicii;
        private System.Windows.Forms.Panel panel1;
    }
}

