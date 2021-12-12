using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Eta
{
    class ADO
    {
        public SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-JB0ULHB\MSSQLSERVERYOUSS;Initial Catalog=creche;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;

        public void connecter()
        {
            if (cnx.State == ConnectionState.Closed)
            {
                cnx.Open();
            }
        }
        public void deconnecter()
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }
    }
}
