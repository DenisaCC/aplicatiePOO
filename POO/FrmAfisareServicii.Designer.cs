namespace POO
{
    partial class FrmAfisareServicii
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
            this.DGVAfisareServicii = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAfisareServicii)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVAfisareServicii
            // 
            this.DGVAfisareServicii.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DGVAfisareServicii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAfisareServicii.Location = new System.Drawing.Point(31, 90);
            this.DGVAfisareServicii.Name = "DGVAfisareServicii";
            this.DGVAfisareServicii.RowHeadersWidth = 51;
            this.DGVAfisareServicii.RowTemplate.Height = 24;
            this.DGVAfisareServicii.Size = new System.Drawing.Size(966, 453);
            this.DGVAfisareServicii.TabIndex = 0;
            this.DGVAfisareServicii.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // FrmAfisareServicii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 574);
            this.Controls.Add(this.DGVAfisareServicii);
            this.MaximizeBox = false;
            this.Name = "FrmAfisareServicii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afișare Servicii";
            this.Load += new System.EventHandler(this.FrmAfisareServicii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAfisareServicii)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVAfisareServicii;
    }
}