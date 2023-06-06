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
    public partial class FrmAfisareZboruriSosiri : MaterialSkin.Controls.MaterialForm
    {
        Conectare conectare = new Conectare();
        SqlDataAdapter dtAp;
        DataTable dt;
        public static int zborSosiriID;
        public FrmAfisareZboruriSosiri()
        {
            InitializeComponent();
        }

        private void FrmAfisareZboruriSosiri_Load(object sender, EventArgs e)
        {
            dtAp = new SqlDataAdapter(" select ZboruriSosiri.zborSosiriID, ZboruriSosiri.nrZborSosiri, ZboruriSosiri.dataZborSosiri,TaraSosiri.numeTaraSosiri, OrasSosiri.numeOrasSosiri, CompanieSosiri.numeCompanieSosiri, StatusSosiri.numeStatusSosiri from ZboruriSosiri inner join TaraSosiri on ZboruriSosiri.taraSosiriID = TaraSosiri.taraSosiriID inner join OrasSosiri on ZboruriSosiri.orasSosiriID = OrasSosiri.orasSosiriID inner join CompanieSosiri on ZboruriSosiri.companieSosiriID = CompanieSosiri.companieSosiriID inner join StatusSosiri on ZboruriSosiri.statusSosiriID = StatusSosiri.statusSosiriID",
                conectare.DeschidereConectare());


            dt = new DataTable();
            dtAp.Fill(dt);
            DGVAfisareZboruriSosiri.DataSource = dt;

            conectare.InchidereConectare();
        }

        private void DGVAfisareZboruriSosiri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Zboruri incarcareDateZborSosiri = new Zboruri();

            zborSosiriID = Convert.ToInt32(DGVAfisareZboruriSosiri.Rows[e.RowIndex].Cells[0].Value.ToString());


            incarcareDateZborSosiri.txtNrZborSosiri.Text = DGVAfisareZboruriSosiri.Rows[e.RowIndex].Cells[1].Value.ToString();
            incarcareDateZborSosiri.dataSosiri.Text = DGVAfisareZboruriSosiri.Rows[e.RowIndex].Cells[2].Value.ToString();
            incarcareDateZborSosiri.cmbTaraSosiri.Text = DGVAfisareZboruriSosiri.Rows[e.RowIndex].Cells[3].Value.ToString();
            incarcareDateZborSosiri.cmbOrasSosiri.Text = DGVAfisareZboruriSosiri.Rows[e.RowIndex].Cells[4].Value.ToString();
            incarcareDateZborSosiri.cmbCompanieSosiri.Text = DGVAfisareZboruriSosiri.Rows[e.RowIndex].Cells[5].Value.ToString();
            incarcareDateZborSosiri.cmbStatusSosiri.Text = DGVAfisareZboruriSosiri.Rows[e.RowIndex].Cells[6].Value.ToString();


            incarcareDateZborSosiri.Show();
            incarcareDateZborSosiri.btnActualizareSosiri.Enabled = true;
            incarcareDateZborSosiri.btnStergereSosiri.Enabled = true;
        }
    }
}
