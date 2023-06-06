namespace POO
{
    partial class FrmAfisarePersonal
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
            this.DGVAfisarePersonal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAfisarePersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVAfisarePersonal
            // 
            this.DGVAfisarePersonal.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DGVAfisarePersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAfisarePersonal.Location = new System.Drawing.Point(37, 92);
            this.DGVAfisarePersonal.Name = "DGVAfisarePersonal";
            this.DGVAfisarePersonal.RowHeadersWidth = 51;
            this.DGVAfisarePersonal.RowTemplate.Height = 24;
            this.DGVAfisarePersonal.Size = new System.Drawing.Size(1054, 378);
            this.DGVAfisarePersonal.TabIndex = 0;
            this.DGVAfisarePersonal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAfisarePersonal_CellDoubleClick);
            // 
            // FrmAfisarePersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 502);
            this.Controls.Add(this.DGVAfisarePersonal);
            this.MaximizeBox = false;
            this.Name = "FrmAfisarePersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afișare personal înregistrat";
            this.Load += new System.EventHandler(this.FrmAfisarePersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAfisarePersonal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVAfisarePersonal;
    }
}