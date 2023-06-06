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
    public partial class Zboruri : MaterialSkin.Controls.MaterialForm

    {
        SqlDataAdapter dataAdpt;
        DataTable dt;
        SqlCommand cmd;
        Conectare conectare = new Conectare();
        public Zboruri()
        {
            InitializeComponent();
            AfisareTariPlecarilsd();
            AfisareTariSosirilsd();
            AfisareStatusPlecarilsd();
            AfisareStatusSosirilsd();
            AfisareCompaniePlecarilsd();
            AfisareCompanieSosirilsd();
            btnActualizarePlecari.Enabled = false;
            btnStergerePlecari.Enabled = false;
            btnActualizareSosiri.Enabled = false;
            btnStergereSosiri.Enabled = false;
        }

        public void AfisareTariPlecarilsd()
        {
            dataAdpt = new SqlDataAdapter("select * from TaraPlecari", conectare.DeschidereConectare());  
            dt = new DataTable();
            dataAdpt.Fill(dt);
            cmbTaraPlecari.DataSource = dt;
            cmbTaraPlecari.DisplayMember = "numeTaraPlecari";
            cmbTaraPlecari.ValueMember = "taraPlecariID";
        }

        public void AfisareTariSosirilsd()
        {
            dataAdpt = new SqlDataAdapter("select * from TaraSosiri", conectare.DeschidereConectare());
            dt = new DataTable();
            dataAdpt.Fill(dt);
            cmbTaraSosiri.DataSource = dt;
            cmbTaraSosiri.DisplayMember = "numeTaraSosiri";
            cmbTaraSosiri.ValueMember = "taraSosiriID";
        }

        public void AfisareStatusPlecarilsd()
        {
            dataAdpt = new SqlDataAdapter("select * from StatusPlecari", conectare.DeschidereConectare());
            dt = new DataTable();
            dataAdpt.Fill(dt);
            cmbStatusPlecari.DataSource = dt;
            cmbStatusPlecari.DisplayMember = "numeStatusPlecari";
            cmbStatusPlecari.ValueMember = "statusPlecariID";
        }

        public void AfisareStatusSosirilsd()
        {
            dataAdpt = new SqlDataAdapter("select * from StatusSosiri", conectare.DeschidereConectare());
            dt = new DataTable();
            dataAdpt.Fill(dt);
            cmbStatusSosiri.DataSource = dt;
            cmbStatusSosiri.DisplayMember = "numeStatusSosiri";
            cmbStatusSosiri.ValueMember = "statusSosiriID";
        }

        public void AfisareCompaniePlecarilsd()
        {
            dataAdpt = new SqlDataAdapter("select * from CompaniePlecari", conectare.DeschidereConectare());
            dt = new DataTable();
            dataAdpt.Fill(dt);
            cmbCompaniePlecari.DataSource = dt;
            cmbCompaniePlecari.DisplayMember = "numeCompaniePlecari";
            cmbCompaniePlecari.ValueMember = "companiePlecariID";
        }

        public void AfisareCompanieSosirilsd()
        {
            dataAdpt = new SqlDataAdapter("select * from CompanieSosiri", conectare.DeschidereConectare());
            dt = new DataTable();
            dataAdpt.Fill(dt);
            cmbCompanieSosiri.DataSource = dt;
            cmbCompanieSosiri.DisplayMember = "numeCompanieSosiri";
            cmbCompanieSosiri.ValueMember = "companieSosiriID";
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataPlecari.Format = DateTimePickerFormat.Custom;
            dataPlecari.CustomFormat = "hh:mm tt dd-MM-yyyy";
            dataPlecari.ShowUpDown = true;
            string dt = dataPlecari.Value.ToString("hh:mm tt dd-MM-yyyy");
        }

        private void dataSosiri_ValueChanged(object sender, EventArgs e)
        {
            dataSosiri.Format = DateTimePickerFormat.Custom;
            dataSosiri.CustomFormat = "hh:mm tt dd-MM-yyyy";
            dataSosiri.ShowUpDown = true;
            string dt = dataSosiri.Value.ToString("hh:mm tt dd-MM-yyyy");
        }

        private void cmbTaraPlecari_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valoare;

            try
            {
                int.TryParse(cmbTaraPlecari.SelectedValue.ToString(), out valoare);
                dataAdpt = new SqlDataAdapter("select * from OrasPlecari where taraPlecariID ='" + valoare + "'", conectare.DeschidereConectare());
                dt = new DataTable();
                dataAdpt.Fill(dt);
                cmbOrasPlecari.DataSource = dt;
                cmbOrasPlecari.DisplayMember = "numeOrasPlecari";
                cmbOrasPlecari.ValueMember = "orasPlecariID";
            }
            catch(Exception)
            {

            }
        }

        private void cmbTaraSosiri_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valoare;

            try
            {
                int.TryParse(cmbTaraSosiri.SelectedValue.ToString(), out valoare);
                dataAdpt = new SqlDataAdapter("select * from OrasSosiri where taraSosiriID ='" + valoare + "'", conectare.DeschidereConectare());
                dt = new DataTable();
                dataAdpt.Fill(dt);
                cmbOrasSosiri.DataSource = dt;
                cmbOrasSosiri.DisplayMember = "numeOrasSosiri";
                cmbOrasSosiri.ValueMember = "orasSosiriID";
            }
            catch (Exception)
            {

            }
        }

        private void btnSalvarePlecari_Click(object sender, EventArgs e)
        {
            int taraPlecariID = Convert.ToInt32(cmbTaraPlecari.SelectedValue);
            int orasPlecariID = Convert.ToInt32(cmbOrasPlecari.SelectedValue);
            int companiePlecariID = Convert.ToInt32(cmbCompaniePlecari.SelectedValue);
            int statusPlecariID = Convert.ToInt32(cmbStatusPlecari.SelectedValue);

            try
            {
                if (cmbTaraPlecari.Text != "" && cmbOrasPlecari.Text != "" && cmbCompaniePlecari.Text != "" &&
                   txtNrZborPlecari.Text != "" && cmbStatusPlecari.Text != "")
                {
                    cmd = new SqlCommand("insert into ZboruriPlecari values('" + txtNrZborPlecari.Text + "', '" + dataPlecari.Text + "', '" +
                       taraPlecariID + "', '" + orasPlecariID + "', '" + companiePlecariID + "', '" +
                       statusPlecariID + "')", conectare.DeschidereConectare());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Datele au fost salvate!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Completați toate câmpurile!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

            }

        }

        private void btnSalvareSosiri_Click(object sender, EventArgs e)
        {
            int taraSosiriID = Convert.ToInt32(cmbTaraSosiri.SelectedValue);
            int orasSosiriID = Convert.ToInt32(cmbOrasSosiri.SelectedValue);
            int companieSosiriID = Convert.ToInt32(cmbCompanieSosiri.SelectedValue);
            int statusSosiriID = Convert.ToInt32(cmbStatusSosiri.SelectedValue);

            try
            {
                if (cmbTaraSosiri.Text != "" && cmbOrasSosiri.Text != "" && cmbCompanieSosiri.Text != "" &&
                   txtNrZborSosiri.Text != "" && cmbStatusSosiri.Text != "")
                {
                    cmd = new SqlCommand("insert into ZboruriSosiri values('" + txtNrZborSosiri.Text + "', '" + dataSosiri.Text + "', '" +
                       taraSosiriID + "', '" + orasSosiriID + "', '" + companieSosiriID + "', '" +
                       statusSosiriID + "')", conectare.DeschidereConectare());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Datele au fost salvate!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Completați toate câmpurile!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnAdaugarePlecari_Click(object sender, EventArgs e)
        {
            cmbTaraPlecari.Text = "";
            cmbOrasPlecari.Text = "";
            cmbCompaniePlecari.Text = "";
            txtNrZborPlecari.Clear();
            cmbStatusPlecari.Text = "";
        }

        private void btnAdaugareSosiri_Click(object sender, EventArgs e)
        {
            cmbTaraSosiri.Text = "";
            cmbOrasSosiri.Text = "";
            cmbCompanieSosiri.Text = "";
            txtNrZborSosiri.Clear();
            cmbStatusSosiri.Text = "";
        }

        private void InregPlecari_Click(object sender, EventArgs e)
        {
            FrmAfisareZboruriPlecari zborPlecari = new FrmAfisareZboruriPlecari();
            zborPlecari.Show();    
        }

        private void InregSosiri_Click_1(object sender, EventArgs e)
        {
            FrmAfisareZboruriSosiri zborSosiri = new FrmAfisareZboruriSosiri();
            zborSosiri.Show();
        }

        private void btnActualizarePlecari_Click(object sender, EventArgs e)
        {
            try
            {
                string DP = dataPlecari.Value.ToString("MM-dd-yyyy");
                int taraPlecariID = Convert.ToInt32(cmbTaraPlecari.SelectedValue);
                int orasPlecariID = Convert.ToInt32(cmbOrasPlecari.SelectedValue);
                int companiePlecariID = Convert.ToInt32(cmbCompaniePlecari.SelectedValue);
                int statusPlecariID = Convert.ToInt32(cmbStatusPlecari.SelectedValue);

                if(cmbTaraPlecari.Text != "" && cmbOrasPlecari.Text != "" && cmbCompaniePlecari.Text != "" &&
                    txtNrZborPlecari.Text != "" && cmbStatusPlecari.Text != "")
                {
                    cmd = new SqlCommand("update ZboruriPlecari set nrZborPlecari= '" + txtNrZborPlecari.Text +
                        "', dataZborPlecari= '" + DP + "', taraPlecariID= '" + taraPlecariID + "', orasPlecariID= '" +
                        orasPlecariID + "', companiePlecariID= '" + companiePlecariID + "', statusPlecariID = '" +
                        statusPlecariID + "' where zborPlecariID='" + FrmAfisareZboruriPlecari.zborPlecariID + "'", conectare.DeschidereConectare());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost actualizate cu succes!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Completează toate câmpurile!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conectare.InchidereConectare();
        }

        private void btnStergerePlecari_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("delete from ZboruriPlecari where zborPlecariID= '" + FrmAfisareZboruriPlecari.zborPlecariID + "'", conectare.DeschidereConectare());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datele au fost șterse!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception)
            {

            }
            conectare.InchidereConectare();
        }

        private void btnActualizareSosiri_Click(object sender, EventArgs e)
        {
            try
            {
                string DS = dataSosiri.Value.ToString("MM-dd-yyyy");
                int taraSosiriID = Convert.ToInt32(cmbTaraSosiri.SelectedValue);
                int orasSosiriID = Convert.ToInt32(cmbOrasSosiri.SelectedValue);
                int companieSosiriID = Convert.ToInt32(cmbCompanieSosiri.SelectedValue);
                int statusSosiriID = Convert.ToInt32(cmbStatusSosiri.SelectedValue);

                if (cmbTaraSosiri.Text != "" && cmbOrasSosiri.Text != "" && cmbCompanieSosiri.Text != "" &&
                    txtNrZborSosiri.Text != "" && cmbStatusSosiri.Text != "")
                {
                    cmd = new SqlCommand("update ZboruriSosiri set nrZborSosiri= '" + txtNrZborSosiri.Text +
                        "', dataZborSosiri= '" + DS + "', taraSosiriID= '" + taraSosiriID + "', orasSosiriID= '" +
                        orasSosiriID + "', companieSosiriID= '" + companieSosiriID + "', statusSosiriID = '" +
                        statusSosiriID + "' where zborSosiriID='" + FrmAfisareZboruriSosiri.zborSosiriID + "'", conectare.DeschidereConectare());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost actualizate cu succes!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Completează toate câmpurile!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conectare.InchidereConectare();
        }

        private void btnStergereSosiri_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("delete from ZboruriSosiri where zborSosiriID= '" + FrmAfisareZboruriSosiri.zborSosiriID + "'", conectare.DeschidereConectare());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datele au fost șterse!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {

            }
            conectare.InchidereConectare();
        }
    }
}
