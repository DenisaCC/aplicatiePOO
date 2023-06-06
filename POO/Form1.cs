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
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InregistrareUtilizatori objInregUtilizatori = new InregistrareUtilizatori();
            objInregUtilizatori.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login obLogin = new Login();
            obLogin.Show();
        }

        private void btnZboruri_Click(object sender, EventArgs e)
        {
            Zboruri obZboruri = new Zboruri();
            obZboruri.Show();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            Personal obPersonal = new Personal();
            obPersonal.Show();
        }

        private void btnPasageri_Click(object sender, EventArgs e)
        {
            Pasageri obPasageri = new Pasageri();
            obPasageri.Show();

        }

        private void btnServicii_Click(object sender, EventArgs e)
        {
            Servicii obServicii = new Servicii();
            obServicii.Show();
        }
    }
}
