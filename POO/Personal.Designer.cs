namespace POO
{
    partial class Personal
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
            this.InregPersonal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStergerePersonal = new System.Windows.Forms.Button();
            this.btnActualizarePersonal = new System.Windows.Forms.Button();
            this.btnAdaugarePersonal = new System.Windows.Forms.Button();
            this.dataNasteriiPersonal = new System.Windows.Forms.DateTimePicker();
            this.txtAdresaPersonal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumePersonal = new System.Windows.Forms.TextBox();
            this.txtNrTelefonPersonal = new System.Windows.Forms.TextBox();
            this.txtPrenumePersonal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmailPersonal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFunctiePersonal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InregPersonal
            // 
            this.InregPersonal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.InregPersonal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InregPersonal.Location = new System.Drawing.Point(768, 81);
            this.InregPersonal.Name = "InregPersonal";
            this.InregPersonal.Size = new System.Drawing.Size(330, 32);
            this.InregPersonal.TabIndex = 23;
            this.InregPersonal.Text = "Vezi aici personalul deja înregistrat";
            this.InregPersonal.UseVisualStyleBackColor = false;
            this.InregPersonal.Click += new System.EventHandler(this.InregPersonal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnSalvare);
            this.groupBox1.Controls.Add(this.btnStergerePersonal);
            this.groupBox1.Controls.Add(this.btnActualizarePersonal);
            this.groupBox1.Controls.Add(this.btnAdaugarePersonal);
            this.groupBox1.Controls.Add(this.dataNasteriiPersonal);
            this.groupBox1.Controls.Add(this.txtAdresaPersonal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumePersonal);
            this.groupBox1.Controls.Add(this.txtNrTelefonPersonal);
            this.groupBox1.Controls.Add(this.txtPrenumePersonal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEmailPersonal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbFunctiePersonal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(29, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1069, 492);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Înregistrare date personal";
            // 
            // btnStergerePersonal
            // 
            this.btnStergerePersonal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnStergerePersonal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStergerePersonal.Location = new System.Drawing.Point(877, 418);
            this.btnStergerePersonal.Name = "btnStergerePersonal";
            this.btnStergerePersonal.Size = new System.Drawing.Size(149, 41);
            this.btnStergerePersonal.TabIndex = 34;
            this.btnStergerePersonal.Text = "Ștergere";
            this.btnStergerePersonal.UseVisualStyleBackColor = false;
            this.btnStergerePersonal.Click += new System.EventHandler(this.btnStergerePersonal_Click);
            // 
            // btnActualizarePersonal
            // 
            this.btnActualizarePersonal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnActualizarePersonal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnActualizarePersonal.Location = new System.Drawing.Point(579, 418);
            this.btnActualizarePersonal.Name = "btnActualizarePersonal";
            this.btnActualizarePersonal.Size = new System.Drawing.Size(149, 41);
            this.btnActualizarePersonal.TabIndex = 33;
            this.btnActualizarePersonal.Text = "Actualizare";
            this.btnActualizarePersonal.UseVisualStyleBackColor = false;
            this.btnActualizarePersonal.Click += new System.EventHandler(this.btnActualizarePersonal_Click);
            // 
            // btnAdaugarePersonal
            // 
            this.btnAdaugarePersonal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdaugarePersonal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdaugarePersonal.Location = new System.Drawing.Point(50, 418);
            this.btnAdaugarePersonal.Name = "btnAdaugarePersonal";
            this.btnAdaugarePersonal.Size = new System.Drawing.Size(149, 41);
            this.btnAdaugarePersonal.TabIndex = 31;
            this.btnAdaugarePersonal.Text = "Adăugare";
            this.btnAdaugarePersonal.UseVisualStyleBackColor = false;
            this.btnAdaugarePersonal.Click += new System.EventHandler(this.btnAdaugarePersonal_Click);
            // 
            // dataNasteriiPersonal
            // 
            this.dataNasteriiPersonal.CustomFormat = "dd-MM-yyyy";
            this.dataNasteriiPersonal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataNasteriiPersonal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataNasteriiPersonal.Location = new System.Drawing.Point(176, 189);
            this.dataNasteriiPersonal.Name = "dataNasteriiPersonal";
            this.dataNasteriiPersonal.Size = new System.Drawing.Size(200, 30);
            this.dataNasteriiPersonal.TabIndex = 30;
            // 
            // txtAdresaPersonal
            // 
            this.txtAdresaPersonal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAdresaPersonal.Location = new System.Drawing.Point(176, 269);
            this.txtAdresaPersonal.Name = "txtAdresaPersonal";
            this.txtAdresaPersonal.Size = new System.Drawing.Size(632, 34);
            this.txtAdresaPersonal.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(30, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 26);
            this.label8.TabIndex = 28;
            this.label8.Text = "Adresă:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(589, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 26;
            this.label2.Text = "Email:";
            // 
            // txtNumePersonal
            // 
            this.txtNumePersonal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNumePersonal.Location = new System.Drawing.Point(176, 85);
            this.txtNumePersonal.Name = "txtNumePersonal";
            this.txtNumePersonal.Size = new System.Drawing.Size(281, 34);
            this.txtNumePersonal.TabIndex = 25;
            // 
            // txtNrTelefonPersonal
            // 
            this.txtNrTelefonPersonal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNrTelefonPersonal.Location = new System.Drawing.Point(176, 344);
            this.txtNrTelefonPersonal.Name = "txtNrTelefonPersonal";
            this.txtNrTelefonPersonal.Size = new System.Drawing.Size(281, 34);
            this.txtNrTelefonPersonal.TabIndex = 24;
            // 
            // txtPrenumePersonal
            // 
            this.txtPrenumePersonal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrenumePersonal.Location = new System.Drawing.Point(738, 88);
            this.txtPrenumePersonal.Name = "txtPrenumePersonal";
            this.txtPrenumePersonal.Size = new System.Drawing.Size(281, 34);
            this.txtPrenumePersonal.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(30, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 26);
            this.label7.TabIndex = 22;
            this.label7.Text = "Nr telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(589, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "Funcție:";
            // 
            // txtEmailPersonal
            // 
            this.txtEmailPersonal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEmailPersonal.Location = new System.Drawing.Point(739, 352);
            this.txtEmailPersonal.Name = "txtEmailPersonal";
            this.txtEmailPersonal.Size = new System.Drawing.Size(281, 34);
            this.txtEmailPersonal.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(30, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "Data Nașterii:";
            // 
            // cmbFunctiePersonal
            // 
            this.cmbFunctiePersonal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbFunctiePersonal.FormattingEnabled = true;
            this.cmbFunctiePersonal.Location = new System.Drawing.Point(738, 189);
            this.cmbFunctiePersonal.Name = "cmbFunctiePersonal";
            this.cmbFunctiePersonal.Size = new System.Drawing.Size(281, 34);
            this.cmbFunctiePersonal.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(589, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Prenume:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(30, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nume:";
            // 
            // btnSalvare
            // 
            this.btnSalvare.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSalvare.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSalvare.Location = new System.Drawing.Point(290, 418);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(167, 41);
            this.btnSalvare.TabIndex = 35;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = false;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 636);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InregPersonal);
            this.MaximizeBox = false;
            this.Name = "Personal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button InregPersonal;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtAdresaPersonal;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtNumePersonal;
        public System.Windows.Forms.TextBox txtNrTelefonPersonal;
        public System.Windows.Forms.TextBox txtPrenumePersonal;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtEmailPersonal;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cmbFunctiePersonal;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnStergerePersonal;
        public System.Windows.Forms.Button btnActualizarePersonal;
        public System.Windows.Forms.Button btnAdaugarePersonal;
        public System.Windows.Forms.DateTimePicker dataNasteriiPersonal;
        private System.Windows.Forms.Button btnSalvare;
    }
}