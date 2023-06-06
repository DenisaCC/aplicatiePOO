namespace POO
{
    partial class InregistrareUtilizatori
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnResetare = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnInregistrare = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGUtilizatori = new System.Windows.Forms.DataGridView();
            this.utilizatorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeUtilizatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUtilizatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeroportDataSet = new POO.aeroportDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFunctie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmareParola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeUtilizator = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tblUtilizatoriTableAdapter = new POO.aeroportDataSetTableAdapters.tblUtilizatoriTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGUtilizatori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUtilizatoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnStergere);
            this.panel1.Controls.Add(this.btnResetare);
            this.panel1.Controls.Add(this.btnActualizare);
            this.panel1.Controls.Add(this.btnInregistrare);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 494);
            this.panel1.TabIndex = 0;
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnStergere.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStergere.Location = new System.Drawing.Point(961, 409);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(191, 53);
            this.btnStergere.TabIndex = 5;
            this.btnStergere.Text = "Ștergere";
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnResetare
            // 
            this.btnResetare.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnResetare.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnResetare.Location = new System.Drawing.Point(655, 409);
            this.btnResetare.Name = "btnResetare";
            this.btnResetare.Size = new System.Drawing.Size(191, 53);
            this.btnResetare.TabIndex = 4;
            this.btnResetare.Text = "Resetare";
            this.btnResetare.UseVisualStyleBackColor = false;
            this.btnResetare.Click += new System.EventHandler(this.btnResetare_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnActualizare.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnActualizare.Location = new System.Drawing.Point(353, 409);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(191, 53);
            this.btnActualizare.TabIndex = 3;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = false;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // btnInregistrare
            // 
            this.btnInregistrare.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnInregistrare.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInregistrare.Location = new System.Drawing.Point(66, 409);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(191, 53);
            this.btnInregistrare.TabIndex = 2;
            this.btnInregistrare.Text = "Înregistrare";
            this.btnInregistrare.UseVisualStyleBackColor = false;
            this.btnInregistrare.Click += new System.EventHandler(this.btnInregistrare_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGUtilizatori);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(552, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(805, 351);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Utilizatori Înregistrați";
            // 
            // DGUtilizatori
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.NullValue = null;
            this.DGUtilizatori.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGUtilizatori.AutoGenerateColumns = false;
            this.DGUtilizatori.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DGUtilizatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUtilizatori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.utilizatorIDDataGridViewTextBoxColumn,
            this.numeUtilizatorDataGridViewTextBoxColumn,
            this.parolaDataGridViewTextBoxColumn,
            this.functiaDataGridViewTextBoxColumn});
            this.DGUtilizatori.DataSource = this.tblUtilizatoriBindingSource;
            this.DGUtilizatori.Location = new System.Drawing.Point(6, 37);
            this.DGUtilizatori.Name = "DGUtilizatori";
            this.DGUtilizatori.RowHeadersWidth = 51;
            this.DGUtilizatori.RowTemplate.Height = 24;
            this.DGUtilizatori.Size = new System.Drawing.Size(793, 308);
            this.DGUtilizatori.TabIndex = 0;
            this.DGUtilizatori.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGUtilizatori_CellEnter);
            // 
            // utilizatorIDDataGridViewTextBoxColumn
            // 
            this.utilizatorIDDataGridViewTextBoxColumn.DataPropertyName = "UtilizatorID";
            this.utilizatorIDDataGridViewTextBoxColumn.HeaderText = "UtilizatorID";
            this.utilizatorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.utilizatorIDDataGridViewTextBoxColumn.Name = "utilizatorIDDataGridViewTextBoxColumn";
            this.utilizatorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.utilizatorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeUtilizatorDataGridViewTextBoxColumn
            // 
            this.numeUtilizatorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.numeUtilizatorDataGridViewTextBoxColumn.DataPropertyName = "NumeUtilizator";
            this.numeUtilizatorDataGridViewTextBoxColumn.HeaderText = "NumeUtilizator";
            this.numeUtilizatorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeUtilizatorDataGridViewTextBoxColumn.Name = "numeUtilizatorDataGridViewTextBoxColumn";
            this.numeUtilizatorDataGridViewTextBoxColumn.Width = 169;
            // 
            // parolaDataGridViewTextBoxColumn
            // 
            this.parolaDataGridViewTextBoxColumn.DataPropertyName = "Parola";
            this.parolaDataGridViewTextBoxColumn.HeaderText = "Parola";
            this.parolaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parolaDataGridViewTextBoxColumn.Name = "parolaDataGridViewTextBoxColumn";
            this.parolaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.parolaDataGridViewTextBoxColumn.Width = 150;
            // 
            // functiaDataGridViewTextBoxColumn
            // 
            this.functiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.functiaDataGridViewTextBoxColumn.DataPropertyName = "Functia";
            this.functiaDataGridViewTextBoxColumn.HeaderText = "Functia";
            this.functiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.functiaDataGridViewTextBoxColumn.Name = "functiaDataGridViewTextBoxColumn";
            this.functiaDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblUtilizatoriBindingSource
            // 
            this.tblUtilizatoriBindingSource.DataMember = "tblUtilizatori";
            this.tblUtilizatoriBindingSource.DataSource = this.aeroportDataSet;
            // 
            // aeroportDataSet
            // 
            this.aeroportDataSet.DataSetName = "aeroportDataSet";
            this.aeroportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.txtParola);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFunctie);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtConfirmareParola);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumeUtilizator);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(25, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Înregistrare Utilizatori";
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(190, 152);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(282, 30);
            this.txtParola.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirmare Parolă";
            // 
            // txtFunctie
            // 
            this.txtFunctie.Location = new System.Drawing.Point(190, 286);
            this.txtFunctie.Name = "txtFunctie";
            this.txtFunctie.Size = new System.Drawing.Size(282, 30);
            this.txtFunctie.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Funcție";
            // 
            // txtConfirmareParola
            // 
            this.txtConfirmareParola.Location = new System.Drawing.Point(190, 215);
            this.txtConfirmareParola.Name = "txtConfirmareParola";
            this.txtConfirmareParola.Size = new System.Drawing.Size(282, 30);
            this.txtConfirmareParola.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(11, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parolă";
            // 
            // txtNumeUtilizator
            // 
            this.txtNumeUtilizator.Location = new System.Drawing.Point(190, 74);
            this.txtNumeUtilizator.Name = "txtNumeUtilizator";
            this.txtNumeUtilizator.Size = new System.Drawing.Size(282, 30);
            this.txtNumeUtilizator.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(11, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume utilizator";
            // 
            // tblUtilizatoriTableAdapter
            // 
            this.tblUtilizatoriTableAdapter.ClearBeforeFill = true;
            // 
            // InregistrareUtilizatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 588);
            this.Controls.Add(this.panel1);
            this.Name = "InregistrareUtilizatori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InregistrareUtilizatori";
            this.Load += new System.EventHandler(this.InregistrareUtilizatori_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGUtilizatori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUtilizatoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnResetare;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnInregistrare;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGUtilizatori;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFunctie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmareParola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeUtilizator;
        private System.Windows.Forms.Label label1;
        private aeroportDataSet aeroportDataSet;
        private System.Windows.Forms.BindingSource tblUtilizatoriBindingSource;
        private aeroportDataSetTableAdapters.tblUtilizatoriTableAdapter tblUtilizatoriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilizatorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeUtilizatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn functiaDataGridViewTextBoxColumn;
    }
}