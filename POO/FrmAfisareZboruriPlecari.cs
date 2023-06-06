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
    public partial class FrmAfisareZboruriPlecari : MaterialSkin.Controls.MaterialForm
    {
        Conectare conectare = new Conectare();
        SqlDataAdapter dtAp;
        DataTable dt;
        public static int zborPlecariID;

        public FrmAfisareZboruriPlecari()
        {
            InitializeComponent();
        }

        private void FrmAfisareZboruriPlecari_Load(object sender, EventArgs e)
        {
            dtAp = new SqlDataAdapter("select ZboruriPlecari.zborPlecariID, ZboruriPlecari.nrZborPlecari, ZboruriPlecari.dataZborPlecari,TaraPlecari.numeTaraPlecari, OrasPlecari.numeOrasPlecari, CompaniePlecari.numeCompaniePlecari, StatusPlecari.numeStatusPlecari from ZboruriPlecari inner join TaraPlecari on ZboruriPlecari.taraPlecariID = TaraPlecari.taraPlecariID inner join OrasPlecari on ZboruriPlecari.orasPlecariID = OrasPlecari.orasPlecariID inner join CompaniePlecari on ZboruriPlecari.companiePlecariID = CompaniePlecari.companiePlecariID inner join StatusPlecari on ZboruriPlecari.statusPlecariID = StatusPlecari.statusPlecariID", conectare.DeschidereConectare());

            dt = new DataTable();
            dtAp.Fill(dt);
            DGVAfisareZboruriPlecari.DataSource = dt;

            conectare.InchidereConectare();
        }

        private void DGVAfisareZboruriPlecari_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Zboruri incarcareDateZborPlecari = new Zboruri();

            zborPlecariID = Convert.ToInt32(DGVAfisareZboruriPlecari.Rows[e.RowIndex].Cells[0].Value.ToString());


            incarcareDateZborPlecari.txtNrZborPlecari.Text = DGVAfisareZboruriPlecari.Rows[e.RowIndex].Cells[1].Value.ToString();
            incarcareDateZborPlecari.dataPlecari.Text = DGVAfisareZboruriPlecari.Rows[e.RowIndex].Cells[2].Value.ToString();
            incarcareDateZborPlecari.cmbTaraPlecari.Text = DGVAfisareZboruriPlecari.Rows[e.RowIndex].Cells[3].Value.ToString();
            incarcareDateZborPlecari.cmbOrasPlecari.Text = DGVAfisareZboruriPlecari.Rows[e.RowIndex].Cells[4].Value.ToString();
            incarcareDateZborPlecari.cmbCompaniePlecari.Text = DGVAfisareZboruriPlecari.Rows[e.RowIndex].Cells[5].Value.ToString();
            incarcareDateZborPlecari.cmbStatusPlecari.Text = DGVAfisareZboruriPlecari.Rows[e.RowIndex].Cells[6].Value.ToString();


            incarcareDateZborPlecari.Show();
            incarcareDateZborPlecari.btnActualizarePlecari.Enabled = true;
            incarcareDateZborPlecari.btnStergerePlecari.Enabled = true;
        }
    }
}
