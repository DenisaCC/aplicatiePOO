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
    public partial class InregistrareUtilizatori : MaterialSkin.Controls.MaterialForm
    {
        private Utilizator objUtilizator;
        private static int UtilizatorID;

        public InregistrareUtilizatori()
        {
            InitializeComponent();
        }


        //Parola trebuie sa aiba minim 8 caractere, o literă mare, o literă mică și un număr
        
        private bool ValidareDateIntrare()
        {
            const int lunMinParola = 8;

            if (txtNumeUtilizator.Text.Length == 0)
            {
                MessageBox.Show("Introdu numele de utilizator!"
                    , "Eroare date de intrare", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtNumeUtilizator.Focus();
                return false;
            }



            if (txtParola.Text.Length == 0)
            {
                MessageBox.Show("Introdu parola!"
                    , "Eroare date de intrare", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtParola.Focus();
                return false;
            }
            else
            {
                if(txtParola.Text.Length < lunMinParola || 
                    VerificaCaractereMari(txtParola.Text) < 1 ||
                    VerificaCaractereMici(txtParola.Text) < 1 ||
                    VerificaNumere(txtParola.Text) < 1 )
                {
                    MessageBox.Show("Introdu o parolă validă!\n" +
                        "Parola trebuie să conțină minim 8 caractere,\n" +
                        "o literă mare, o literă mică și un număr!",
                        "Eroare date de intrare", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtParola.Focus();

                    return false;
                }
            }

            if (txtConfirmareParola.Text.Length == 0)
            {
                MessageBox.Show("Confirmă parola!"
                    , "Eroare date de intrare", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtConfirmareParola.Focus();
                return false;

            }
            else
            {
                if (txtParola.Text != txtConfirmareParola.Text)
                {
                    MessageBox.Show("Parolele introduse nu corespund!"
                      , "Eroare date de intrare", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    txtConfirmareParola.Focus();
                    return false;
                }
            }

            if (txtFunctie.Text.Length == 0)
            {
                MessageBox.Show("Introdu funcția!"
                    , "Eroare date de intrare", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtFunctie.Focus();
                return false;
            }

            return true;
        }

        private int VerificaNumere(string parola)
        {
            int nr = 0;
            foreach(char ch in parola)
            {
                if (char.IsNumber(ch))
                    nr++;
            }
            return nr;
        }

        private int VerificaCaractereMici(string parola)
        {

            int nr = 0;
            foreach (char ch in parola)
            {
                if (char.IsLetter(ch))
                    nr++;
            }
            return nr;
        }

        private int VerificaCaractereMari(string parola)
        {

            int nr = 0;
            foreach (char ch in parola)
            {
                if (char.IsUpper(ch))
                    nr++;
            }
            return nr;
        }

        private void ClearControlors()
        {
            txtNumeUtilizator.Clear();
            txtParola.Clear();
            txtConfirmareParola.Clear();
            txtFunctie.Clear();
        }


        private void InregistrareUtilizatori_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aeroportDataSet.tblUtilizatori' table. You can move, or remove it, as needed.
            this.tblUtilizatoriTableAdapter.Fill(this.aeroportDataSet.tblUtilizatori);

        }

        private void btnResetare_Click(object sender, EventArgs e)
        {
            ClearControlors();
            txtNumeUtilizator.Focus();
        }

        private void btnInregistrare_Click(object sender, EventArgs e)
        {
            //objUtilizator = new Utilizator();
            this.DateUtilizator();
            if (ValidareDateIntrare())
            {
               
                //MessageBox.Show("Datele au fost validate cu succes!");
                objUtilizator.Adauga();
            }

            // TODO: This line of code loads data into the 'aeroportDataSet.tblUtilizatori' table. You can move, or remove it, as needed.
            this.tblUtilizatoriTableAdapter.Fill(this.aeroportDataSet.tblUtilizatori);

            ClearControlors();
        }

        private void DateUtilizator()
        {
            objUtilizator = new Utilizator();
            objUtilizator.NumeUtilizator = txtNumeUtilizator.Text;
            objUtilizator.Parola = txtParola.Text;
            objUtilizator.Functie = txtFunctie.Text;
            
        }

       

        private void DGUtilizatori_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection celule = DGUtilizatori.CurrentRow.Cells;
            UtilizatorID = Convert.ToInt32(celule[0].Value.ToString());
            txtNumeUtilizator.Text = celule[1].Value.ToString();
            txtParola.Text = celule[2].Value.ToString();    
            txtConfirmareParola.Text = celule[2].Value.ToString();
            txtFunctie.Text = celule[3].Value.ToString();
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            this.DateUtilizator();
            if (ValidareDateIntrare())
            {

                //MessageBox.Show("Datele au fost validate cu succes!");
                objUtilizator.Actualizare(UtilizatorID);
            }

            // TODO: This line of code loads data into the 'aeroportDataSet.tblUtilizatori' table. You can move, or remove it, as needed.
            this.tblUtilizatoriTableAdapter.Fill(this.aeroportDataSet.tblUtilizatori);

            ClearControlors();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            this.DateUtilizator();
            if (ValidareDateIntrare())
            {

                //MessageBox.Show("Datele au fost validate cu succes!");
                objUtilizator.Sterge(UtilizatorID);
            }

            // TODO: This line of code loads data into the 'aeroportDataSet.tblUtilizatori' table. You can move, or remove it, as needed.
            this.tblUtilizatoriTableAdapter.Fill(this.aeroportDataSet.tblUtilizatori);

            ClearControlors();
        }
    }
}
