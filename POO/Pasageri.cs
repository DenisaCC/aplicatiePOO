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
    public partial class Pasageri : MaterialSkin.Controls.MaterialForm
    {
        SqlDataAdapter dataAdpt;
        DataTable dt;
        SqlCommand cmd;
        Conectare conectare = new Conectare();
       
        public Pasageri()
        {
            InitializeComponent();
            AfisareTipZborlsd();
            btnResetare.Enabled = false;
            btnStergere.Enabled = false;
        }

        public void AfisareTipZborlsd()
        {
            dataAdpt = new SqlDataAdapter("select * from TipZbor", conectare.DeschidereConectare());
            dt = new DataTable();
            dataAdpt.Fill(dt);
            cmbTip.DataSource = dt;
            cmbTip.DisplayMember = "numeTip";
            cmbTip.ValueMember = "tipID";
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            int tipID = Convert.ToInt32(cmbTip.SelectedValue);

            try
            {
                string sex = "Feminin";
                if(rdMasculin.Checked)
                {
                    sex = "Masculin";
                }

                if (txtNumePasageri.Text != "" && txtPrenumePasageri.Text != "" && txtNrTelefonPasageri.Text != "" &&
                   txtEmailPasageri.Text != "" && txtNrZborPasageri.Text != "" && cmbTip.Text != "")
                {
                    cmd = new SqlCommand("insert into Pasageri values('" + txtNumePasageri.Text + "', '" + txtPrenumePasageri.Text + "', '" +
                       sex + "', '" + txtNrTelefonPasageri.Text + "', '" + txtEmailPasageri.Text + "', '" +
                       txtNrZborPasageri.Text + "', '" + tipID + "')", conectare.DeschidereConectare());

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

        private void btnResetare_Click(object sender, EventArgs e)
        {
            txtNumePasageri.Clear();
            txtPrenumePasageri.Clear();
            txtNrTelefonPasageri.Clear();
            txtEmailPasageri.Clear();
            txtNrZborPasageri.Clear();
            cmbTip.Text = "";
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("delete from Pasageri where pasagerID= '" + FrmAfisarePasageri.pasagerID + "'", conectare.DeschidereConectare());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datele au fost șterse!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {

            }
            conectare.InchidereConectare();
        }

        private void btnInregPasageri_Click(object sender, EventArgs e)
        {
            FrmAfisarePasageri pasageri = new FrmAfisarePasageri();
            pasageri.Show();
        }
    }
}
