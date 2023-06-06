using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POO
{
    internal class Conectare
    {
        SqlConnection conectare;

        public Conectare()
            {
            conectare = new SqlConnection(@"Data Source=LAPTOP-FPL3PSBN\SQLEXPRESS; Initial Catalog=aeroport; Integrated security=True");

            }

        public SqlConnection DeschidereConectare()
        {
            try
            {
                conectare.Open();
            }
            catch (Exception ex)
            {

            }
            return conectare;
        }

        public void InchidereConectare()
        {
            try
            {
                conectare.Close();
            }
            catch (Exception ex)
            {

            }
           
        }
    }
}
