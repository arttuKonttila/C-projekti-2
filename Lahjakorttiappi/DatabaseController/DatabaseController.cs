using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Lahjakorttiappi.DatabaseController
{
    class DatabaseController
    {
        //Connects to sql database
        SqlConnection connect = new SqlConnection();
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\Lahjakorttiappi\Lahjakortti.mdf;Integrated Security=True";

        public bool connectDatabase()
        {
            connect.ConnectionString = connectionString;
            try
            {
                connect.Open();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Virheilmoitukset:" + e);
                connect.Close();
                return false;
            }
        }

    }
}
