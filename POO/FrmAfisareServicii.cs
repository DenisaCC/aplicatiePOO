using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POO
{
    public partial class FrmAfisareServicii : MaterialSkin.Controls.MaterialForm
    {
        Conectare conectare = new Conectare();
        SqlDataAdapter dtAp;
        DataTable dt;
        public static int serviciuID;
        public FrmAfisareServicii()
        {
            InitializeComponent();
        }

        private void FrmAfisareServicii_Load(object sender, EventArgs e)
        {
            dtAp = new SqlDataAdapter("select Servicii.serviciuID, Servicii.program, Servicii.locatie,Servicii.contact, Categorii.numeCategorie, Denumiri.nume from Servicii inner join Categorii on Servicii.categorieID = Categorii.categorieID inner join Denumiri on Servicii.denumireID = Denumiri.denumireID",
                conectare.DeschidereConectare());

            dt = new DataTable();
            dtAp.Fill(dt);
            DGVAfisareServicii.DataSource = dt;

            conectare.InchidereConectare();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           Servicii incarcareDateServicii = new Servicii();

            serviciuID = Convert.ToInt32(DGVAfisareServicii.Rows[e.RowIndex].Cells[0].Value.ToString());
            incarcareDateServicii.txtProgram.Text = DGVAfisareServicii.Rows[e.RowIndex].Cells[1].Value.ToString();
            incarcareDateServicii.txtLocatie.Text = DGVAfisareServicii.Rows[e.RowIndex].Cells[2].Value.ToString();
            incarcareDateServicii.txtContact.Text = DGVAfisareServicii.Rows[e.RowIndex].Cells[3].Value.ToString();
            incarcareDateServicii.cmbCategorie.Text = DGVAfisareServicii.Rows[e.RowIndex].Cells[4].Value.ToString();
            incarcareDateServicii.cmbDenumire.Text = DGVAfisareServicii.Rows[e.RowIndex].Cells[5].Value.ToString();


            incarcareDateServicii.Show();
            incarcareDateServicii.btnActualizare.Enabled = true;
            incarcareDateServicii.btnStergereServicii.Enabled = true;
        }

        
        
    }
}
