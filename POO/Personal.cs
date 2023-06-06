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
    public partial class Personal : MaterialSkin.Controls.MaterialForm
    {
        SqlDataAdapter dataAdpt;
        DataTable dt;
        SqlCommand cmd;
        Conectare conectare = new Conectare();
        public Personal()
        {
            InitializeComponent();
            AfisareFunctiiPersonallsd();
            btnActualizarePersonal.Enabled = false;
            btnStergerePersonal.Enabled = false;
        }

        public void AfisareFunctiiPersonallsd()
        {
            dataAdpt = new SqlDataAdapter("select * from FunctiePersonal", conectare.DeschidereConectare());
            dt = new DataTable();
            dataAdpt.Fill(dt);
            cmbFunctiePersonal.DataSource = dt;
            cmbFunctiePersonal.DisplayMember = "numeFunctiePersonal";
            cmbFunctiePersonal.ValueMember = "functiePersonalID";
        }

        private void btnAdaugarePersonal_Click(object sender, EventArgs e)
        {
            txtNumePersonal.Clear();
            txtPrenumePersonal.Clear();
            dataNasteriiPersonal.Refresh();
            cmbFunctiePersonal.Text = "";
            txtAdresaPersonal.Clear();
            txtNrTelefonPersonal.Clear();
            txtEmailPersonal.Clear();
        }

        private void InregPlecari_Click(object sender, EventArgs e)
        {
            
        }

        private void btnActualizarePersonal_Click(object sender, EventArgs e)
        {
            try
            {
                string DN = dataNasteriiPersonal.Value.ToString("MM-dd-yyyy");
                int functiePersonalID = Convert.ToInt32(cmbFunctiePersonal.SelectedValue);
            

                if (txtNumePersonal.Text != "" && txtPrenumePersonal.Text != "" && cmbFunctiePersonal.Text != "" &&
                    txtAdresaPersonal.Text != "" && txtNrTelefonPersonal.Text != "" && txtEmailPersonal.Text != "")
                {
                    cmd = new SqlCommand("update Personal set numePersonal= '" + txtNumePersonal.Text +
                        "', prenumePersonal= '" + txtPrenumePersonal.Text + "', dataNasterii= '" + DN +  
                        "', adresaPersonal= '" + txtAdresaPersonal.Text + "', nrTelefonPersonal = '" +
                        txtNrTelefonPersonal.Text + "', emailPersonal= '" + txtEmailPersonal.Text + "', functiePersonallID= '" +
                        functiePersonalID + "' where personalID= '" + FrmAfisarePersonal.personalID + "'", conectare.DeschidereConectare());

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

        private void btnStergerePersonal_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("delete from Personal where personalID= '" + FrmAfisarePersonal.personalID + "'", conectare.DeschidereConectare());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datele au fost șterse!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {

            }
            conectare.InchidereConectare();
        }

       

        private void InregPersonal_Click(object sender, EventArgs e)
        {
            FrmAfisarePersonal personal = new FrmAfisarePersonal();
            personal.Show();
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            int functie1PersonalID = Convert.ToInt32(cmbFunctiePersonal.SelectedValue);

            try
            {
                if (txtNumePersonal.Text != "" && txtPrenumePersonal.Text != "" && cmbFunctiePersonal.Text != "" &&
                   txtAdresaPersonal.Text != "" && txtNrTelefonPersonal.Text != "" && txtEmailPersonal.Text != "")
                {
                    cmd = new SqlCommand("insert into Personal values('" + txtNumePersonal.Text + "', '" + txtPrenumePersonal.Text + "', '" +
                        dataNasteriiPersonal.Text + "', '" + txtAdresaPersonal.Text + "', '" + txtNrTelefonPersonal.Text + "', '" +
                       txtEmailPersonal.Text + "', '" + functie1PersonalID + "')", conectare.DeschidereConectare());

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
