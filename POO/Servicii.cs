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
    public partial class Servicii : MaterialSkin.Controls.MaterialForm
    {
        SqlDataAdapter dataAdpt;
        DataTable dt;
        SqlCommand cmd;
        Conectare conectare = new Conectare();
        public Servicii()
        {
            InitializeComponent();
            AfisareCategoriilsd();
            btnActualizare.Enabled = false;
            btnStergereServicii.Enabled = false;
        }

        public void AfisareCategoriilsd()
        {
            dataAdpt = new SqlDataAdapter("select * from Categorii", conectare.DeschidereConectare());
            dt = new DataTable();
            dataAdpt.Fill(dt);
            cmbCategorie.DataSource = dt;
            cmbCategorie.DisplayMember = "numeCategorie";
            cmbCategorie.ValueMember = "categorieID";
        }

        private void cmbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valoare;

            try
            {
                int.TryParse(cmbCategorie.SelectedValue.ToString(), out valoare);

                dataAdpt = new SqlDataAdapter("select * from Denumiri where CategorieID ='" + valoare + "'", conectare.DeschidereConectare());
                dt = new DataTable();
                dataAdpt.Fill(dt);
                cmbDenumire.DataSource = dt;
                cmbDenumire.DisplayMember = "nume";
                cmbDenumire.ValueMember = "denumireID";
            }
            catch (Exception)
            {

            }
        }

        

        
        private void btnStergereServicii_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("delete from Servicii where serviciuID= '" + FrmAfisareServicii.serviciuID + "'", conectare.DeschidereConectare());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datele au fost șterse!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {

            }
            conectare.InchidereConectare();
        }

        private void btnResetareServicii_Click(object sender, EventArgs e)
        {
            cmbCategorie.Text = "";
            cmbDenumire.Text = "";
            txtProgram.Clear();
            txtLocatie.Clear();
            txtContact.Clear();
        }

        private void btnInregServicii_Click(object sender, EventArgs e)
        {
            FrmAfisareServicii serviciu = new FrmAfisareServicii();
            serviciu.Show();
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {

            try
            {
                
                int categorieID = Convert.ToInt32(cmbCategorie.SelectedValue);
                int denumireID = Convert.ToInt32(cmbDenumire.SelectedValue);
                

                if (cmbCategorie.Text != "" && cmbDenumire.Text != "" && txtProgram.Text != "" &&
                    txtLocatie.Text != "" && txtProgram.Text != "")
                {
                    cmd = new SqlCommand("update Servicii set program= '" + txtProgram.Text +
                        "', locatie= '" + txtLocatie.Text + "', contact= '" + txtContact.Text + "', denumireID= '" +
                        denumireID + "', categorieID= '" + categorieID + "' where serviciuID='" + FrmAfisareServicii.serviciuID + "'", conectare.DeschidereConectare());

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

        private void btnSalvare_Click(object sender, EventArgs e)
        {

            int categorieID = Convert.ToInt32(cmbCategorie.SelectedValue);
            int denumireID = Convert.ToInt32(cmbDenumire.SelectedValue);

            try
            {
                if (cmbCategorie.Text != "" && cmbDenumire.Text != "" && txtProgram.Text != "" &&
                   txtLocatie.Text != "" && txtContact.Text != "")
                {
                    cmd = new SqlCommand("insert into Servicii values('" + txtProgram.Text + "', '" + txtLocatie.Text + "', '" +
                       txtContact.Text + "', '" + denumireID + "', '" + categorieID + "')", conectare.DeschidereConectare());

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
    }
}
