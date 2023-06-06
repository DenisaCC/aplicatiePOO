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
    public partial class FrmAfisarePersonal : MaterialSkin.Controls.MaterialForm
    {
        Conectare conectare = new Conectare();
        SqlDataAdapter dtAp;
        DataTable dt;
        public static int personalID;
        public FrmAfisarePersonal()
        {
            InitializeComponent();
        }

        private void FrmAfisarePersonal_Load(object sender, EventArgs e)
        {
            dtAp = new SqlDataAdapter("select Personal.personalID, Personal.numePersonal, Personal.prenumePersonal, Personal.dataNasterii, Personal.adresaPersonal, Personal.nrTelefonPersonal, Personal.emailPersonal, FunctiePersonal.numeFunctiePersonal from Personal inner join FunctiePersonal on Personal.functiePersonallID = FunctiePersonal.functiePersonalID",
                conectare.DeschidereConectare());

            dt = new DataTable();
            dtAp.Fill(dt);
            DGVAfisarePersonal.DataSource = dt;

            conectare.InchidereConectare();
        }

        private void DGVAfisarePersonal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Personal incarcareDatePersonal = new Personal();

            personalID = Convert.ToInt32(DGVAfisarePersonal.Rows[e.RowIndex].Cells[0].Value.ToString());


            incarcareDatePersonal.txtNumePersonal.Text = DGVAfisarePersonal.Rows[e.RowIndex].Cells[1].Value.ToString();
            incarcareDatePersonal.txtPrenumePersonal.Text = DGVAfisarePersonal.Rows[e.RowIndex].Cells[2].Value.ToString();
            incarcareDatePersonal.dataNasteriiPersonal.Text = DGVAfisarePersonal.Rows[e.RowIndex].Cells[3].Value.ToString();
            
            incarcareDatePersonal.txtAdresaPersonal.Text = DGVAfisarePersonal.Rows[e.RowIndex].Cells[4].Value.ToString();
            incarcareDatePersonal.txtNrTelefonPersonal.Text = DGVAfisarePersonal.Rows[e.RowIndex].Cells[5].Value.ToString();
            incarcareDatePersonal.txtEmailPersonal.Text = DGVAfisarePersonal.Rows[e.RowIndex].Cells[6].Value.ToString();
            incarcareDatePersonal.cmbFunctiePersonal.Text = DGVAfisarePersonal.Rows[e.RowIndex].Cells[7].Value.ToString();
            incarcareDatePersonal.Show();
            incarcareDatePersonal.btnActualizarePersonal.Enabled = true;
            incarcareDatePersonal.btnStergerePersonal.Enabled = true;
        }
    }
}
