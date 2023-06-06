namespace POO
{
    partial class FrmAfisarePasageri
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
            this.DGVAfisarePasageri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAfisarePasageri)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVAfisarePasageri
            // 
            this.DGVAfisarePasageri.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DGVAfisarePasageri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAfisarePasageri.Location = new System.Drawing.Point(46, 100);
            this.DGVAfisarePasageri.Name = "DGVAfisarePasageri";
            this.DGVAfisarePasageri.RowHeadersWidth = 51;
            this.DGVAfisarePasageri.RowTemplate.Height = 24;
            this.DGVAfisarePasageri.Size = new System.Drawing.Size(1030, 424);
            this.DGVAfisarePasageri.TabIndex = 0;
            this.DGVAfisarePasageri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAfisarePasageri_CellDoubleClick);
            // 
            // FrmAfisarePasageri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 572);
            this.Controls.Add(this.DGVAfisarePasageri);
            this.MaximizeBox = false;
            this.Name = "FrmAfisarePasageri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afișare Pasageri";
            this.Load += new System.EventHandler(this.FrmAfisarePasageri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAfisarePasageri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVAfisarePasageri;
    }
}