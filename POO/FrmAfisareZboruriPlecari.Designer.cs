namespace POO
{
    partial class FrmAfisareZboruriPlecari
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
            this.DGVAfisareZboruriPlecari = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAfisareZboruriPlecari)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVAfisareZboruriPlecari
            // 
            this.DGVAfisareZboruriPlecari.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DGVAfisareZboruriPlecari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAfisareZboruriPlecari.Location = new System.Drawing.Point(32, 98);
            this.DGVAfisareZboruriPlecari.Name = "DGVAfisareZboruriPlecari";
            this.DGVAfisareZboruriPlecari.RowHeadersWidth = 51;
            this.DGVAfisareZboruriPlecari.RowTemplate.Height = 24;
            this.DGVAfisareZboruriPlecari.Size = new System.Drawing.Size(998, 436);
            this.DGVAfisareZboruriPlecari.TabIndex = 0;
           
            this.DGVAfisareZboruriPlecari.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAfisareZboruriPlecari_CellDoubleClick);
            // 
            // FrmAfisareZboruriPlecari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 578);
            this.Controls.Add(this.DGVAfisareZboruriPlecari);
            this.Name = "FrmAfisareZboruriPlecari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afisare Zboruri Plecari";
            this.Load += new System.EventHandler(this.FrmAfisareZboruriPlecari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAfisareZboruriPlecari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVAfisareZboruriPlecari;
    }
}