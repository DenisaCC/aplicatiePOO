namespace POO
{
    partial class FrmAfisareZboruriSosiri
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
            this.DGVAfisareZboruriSosiri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAfisareZboruriSosiri)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVAfisareZboruriSosiri
            // 
            this.DGVAfisareZboruriSosiri.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DGVAfisareZboruriSosiri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAfisareZboruriSosiri.Location = new System.Drawing.Point(36, 110);
            this.DGVAfisareZboruriSosiri.Name = "DGVAfisareZboruriSosiri";
            this.DGVAfisareZboruriSosiri.RowHeadersWidth = 51;
            this.DGVAfisareZboruriSosiri.RowTemplate.Height = 24;
            this.DGVAfisareZboruriSosiri.Size = new System.Drawing.Size(1054, 443);
            this.DGVAfisareZboruriSosiri.TabIndex = 0;
          
            this.DGVAfisareZboruriSosiri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAfisareZboruriSosiri_CellDoubleClick);
            // 
            // FrmAfisareZboruriSosiri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 618);
            this.Controls.Add(this.DGVAfisareZboruriSosiri);
            this.MaximizeBox = false;
            this.Name = "FrmAfisareZboruriSosiri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afisare Zboruri Sosiri";
            this.Load += new System.EventHandler(this.FrmAfisareZboruriSosiri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAfisareZboruriSosiri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVAfisareZboruriSosiri;
    }
}