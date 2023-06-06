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
    public partial class FrmAfisarePasageri : MaterialSkin.Controls.MaterialForm
    {
        Conectare conectare = new Conectare();
        SqlDataAdapter dtAp;
        DataTable dt;
        public static int pasagerID;

        public FrmAfisarePasageri()
        {
            InitializeComponent();
        }

        private void FrmAfisarePasageri_Load(object sender, EventArgs e)
        {
            dtAp = new SqlDataAdapter("select Pasageri.pasagerID, Pasageri.numePasager, Pasageri.prenumePasager, Pasageri.sex, Pasageri.nrTelefonPasager, Pasageri.emailPasager, Pasageri.nrZbor, TipZbor.numeTip from Pasageri inner join TipZbor on Pasageri.tipID = TipZbor.tipID", 
                conectare.DeschidereConectare());

            dt = new DataTable();
            dtAp.Fill(dt);
            DGVAfisarePasageri.DataSource = dt;

            conectare.InchidereConectare();
        }

        private void DGVAfisarePasageri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Pasageri incarcareDatePasageri = new Pasageri();

            pasagerID = Convert.ToInt32(DGVAfisarePasageri.Rows[e.RowIndex].Cells[0].Value.ToString());


            incarcareDatePasageri.txtNumePasageri.Text = DGVAfisarePasageri.Rows[e.RowIndex].Cells[1].Value.ToString();
            incarcareDatePasageri.txtPrenumePasageri.Text = DGVAfisarePasageri.Rows[e.RowIndex].Cells[2].Value.ToString();
            incarcareDatePasageri.rdFeminin.Checked = false;
            incarcareDatePasageri.rdMasculin.Checked = true;
            if (DGVAfisarePasageri.Rows[e.RowIndex].Cells[3].Value.ToString() == "Feminin")
            {
                incarcareDatePasageri.rdMasculin.Checked = false;
                incarcareDatePasageri.rdFeminin.Checked = true;
            }
            incarcareDatePasageri.txtNrTelefonPasageri.Text = DGVAfisarePasageri.Rows[e.RowIndex].Cells[4].Value.ToString();
            incarcareDatePasageri.txtEmailPasageri.Text = DGVAfisarePasageri.Rows[e.RowIndex].Cells[5].Value.ToString();
            incarcareDatePasageri.txtNrZborPasageri.Text = DGVAfisarePasageri.Rows[e.RowIndex].Cells[6].Value.ToString();
            incarcareDatePasageri.cmbTip.Text = DGVAfisarePasageri.Rows[e.RowIndex].Cells[7].Value.ToString();


            incarcareDatePasageri.Show();
            incarcareDatePasageri.btnResetare.Enabled = true;
            incarcareDatePasageri.btnStergere.Enabled = true;
        }
    }
}
