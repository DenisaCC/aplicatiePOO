using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace POO
{
    public class Utilizator
    {
        SqlDataAdapter adapter;
        DataSet ds;
        private string numeUtilizator;
        private string parola;
        private string functie;

        public Utilizator()
        {

        }
        public string NumeUtilizator
        {
            get { return numeUtilizator; }
            set { numeUtilizator = value; }
        }

        public string Parola
        {
            get { return parola; }
            set { parola = value; }
        }
        public string Functie
        {
            get { return functie; }
            set { functie = value; }
        }

        public void Adauga()
        {
            string conectare = ConfigurationManager.ConnectionStrings["POOConnectionString"].ConnectionString;

            SqlConnection obSqlConectare = new SqlConnection(conectare);
            try
            {
                SqlCommand obSqlCommandVerificare = new SqlCommand("VerificareUtilizatori", obSqlConectare);
                obSqlCommandVerificare.CommandType = CommandType.StoredProcedure;
                obSqlCommandVerificare.Parameters.AddWithValue("@NumeUtilizator", NumeUtilizator);
                obSqlCommandVerificare.Parameters.AddWithValue("@Parola", Parola);
                obSqlConectare.Open();

                adapter = new SqlDataAdapter(obSqlCommandVerificare);
                ds = new DataSet();
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count >= 1)
                {
                    MessageBox.Show("Numele de utilizator sau Parola există în baza de date!");
                }
                else
                {
                    SqlCommand obSqlCommand = new SqlCommand("AdaugareUtilizator", obSqlConectare);
                    obSqlCommand.CommandType = CommandType.StoredProcedure;
                    obSqlCommand.Parameters.AddWithValue("@NumeUtilizator", NumeUtilizator);
                    obSqlCommand.Parameters.AddWithValue("@Parola", Parola);
                    obSqlCommand.Parameters.AddWithValue("@Functia", Functie);

                    obSqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Utilizator adăugat cu succes!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            
            catch (Exception ex)
            {
                MessageBox.Show("Eroare " + ex.Message, "Eroare inserare valori SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                obSqlConectare.Close();
                
            }
            
        }

        public void Actualizare(int id)
        {
            string conectare = ConfigurationManager.ConnectionStrings["POOConnectionString"].ConnectionString;

            SqlConnection obSqlConectare = new SqlConnection(conectare);
            try
            {
                SqlCommand obSqlCommandVerificare = new SqlCommand("VerificareUtilizatori", obSqlConectare);
                obSqlCommandVerificare.CommandType = CommandType.StoredProcedure;
                obSqlCommandVerificare.Parameters.AddWithValue("@NumeUtilizator", NumeUtilizator);
                obSqlCommandVerificare.Parameters.AddWithValue("@Parola", Parola);
                obSqlConectare.Open();

                adapter = new SqlDataAdapter(obSqlCommandVerificare);
                ds = new DataSet();
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count >= 1)
                {
                    MessageBox.Show("Numele de utilizator sau Parola există în baza de date!");

                    return;
                }
                else
                {
                    SqlCommand obSqlCommand = new SqlCommand("ActualizareUtilizatori", obSqlConectare);
                    obSqlCommand.CommandType = CommandType.StoredProcedure;
                    obSqlCommand.Parameters.AddWithValue("@UtilizatorID", id);
                    obSqlCommand.Parameters.AddWithValue("@NumeUtilizator", NumeUtilizator);
                    obSqlCommand.Parameters.AddWithValue("@Parola", Parola);
                    obSqlCommand.Parameters.AddWithValue("@Functia", Functie);

                    obSqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Utilizator actualizat cu succes!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Eroare " + ex.Message, "Eroare actualizare valori SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                obSqlConectare.Close();

            }
        }

        public void Sterge(int id)
        {

            string conectare = ConfigurationManager.ConnectionStrings["POOConnectionString"].ConnectionString;

            SqlConnection obSqlConectare = new SqlConnection(conectare);

            SqlCommand obSqlCommand = new SqlCommand("StergereUtilizatori", obSqlConectare);
            obSqlCommand.CommandType = CommandType.StoredProcedure;
            obSqlCommand.Parameters.AddWithValue("@UtilizatorID", id);

            try
            {
                
                obSqlConectare.Open();
                obSqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare " + ex.Message, "Eroare ștergere valori SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                obSqlConectare.Close();

            }
        MessageBox.Show("Utilizator șters cu succes!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        public bool AutorizareUtilizator()
        {
            bool esteUtilizatorAutorizat = false;

            string conectare = ConfigurationManager.ConnectionStrings["POOConnectionString"].ConnectionString;

            SqlConnection obSqlConectare = new SqlConnection(conectare);
            
                SqlCommand obSqlCommand = new SqlCommand("esteUtilizatorValid", obSqlConectare);
                obSqlCommand.CommandType = CommandType.StoredProcedure;
                obSqlCommand.Parameters.AddWithValue("@NumeUtilizator", NumeUtilizator);
                obSqlCommand.Parameters.AddWithValue("@Parola", Parola);
            
            try { 
                obSqlConectare.Open();
                esteUtilizatorAutorizat = (bool)obSqlCommand.ExecuteScalar();
                }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare " + ex.Message, "Utilizator neautorizat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                obSqlConectare.Close();
            }
            return esteUtilizatorAutorizat;
        }


        public bool AutorizareAdmin()
        {
            bool esteAdminValid = false;

            string conectare = ConfigurationManager.ConnectionStrings["POOConnectionString"].ConnectionString;

            SqlConnection obSqlConectare = new SqlConnection(conectare);

            SqlCommand obSqlCommand = new SqlCommand("esteAdminValid", obSqlConectare);
            obSqlCommand.CommandType = CommandType.StoredProcedure;
            obSqlCommand.Parameters.AddWithValue("@Admin", NumeUtilizator);
            obSqlCommand.Parameters.AddWithValue("@Parola", Parola);

            try
            {
                obSqlConectare.Open();
                esteAdminValid = (bool)obSqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare " + ex.Message, "Admin invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                obSqlConectare.Close();
            }
            return esteAdminValid;
        }

    }

}
