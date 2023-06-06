using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        private Utilizator obUtilizator;
        public Login()
        {
            InitializeComponent();
        }

        private void DataUtilizator()
        {
            obUtilizator.NumeUtilizator = txtLoginUtilizator.Text;
            obUtilizator.Parola = txtLoginParola.Text;
        }
        private void ClearControlors()
        {
            txtLoginUtilizator.Clear();
            txtLoginParola.Clear();
        }
      
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkShowPsw.Checked)
            {
                txtLoginParola.UseSystemPasswordChar = false;
            }
            else
            {
                txtLoginParola.UseSystemPasswordChar = true;    
            }
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            obUtilizator = new Utilizator();    

            DataUtilizator();

            try
            {
                if(obUtilizator.AutorizareUtilizator())
                {
                    Form1 ob = new Form1();
                    this.Hide();
                    ob.Show();
                    ob.btnAdmin.Enabled = false;
                   
                }
                else if (obUtilizator.AutorizareAdmin())
                {
                    Form1 ob = new Form1();
                    this.Hide();
                    ob.Show();
                   ob.btnAdmin.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Utilizator/Parola neautorizata!!", "Utilizator/Administrator neautorizat",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearControlors();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}

