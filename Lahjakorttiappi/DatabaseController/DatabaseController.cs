using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Lahjakorttiappi.DatabaseController
{
    class DatabaseController
    {
       

        //Connects to sql database
        SqlConnection connect = new SqlConnection();
        // string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\arttu\source\repos\Lahjakorttiappi\Lahjakorttiappi\Lahjakortti.mdf;Integrated Security=True";
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Lahjakortti;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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

        //Closes the connection between the database
        public void disconnectDatabse()
        {
            connect.Close();
        }

        //Gets all data from Asiakastiedot table
        public DataSet bringAllData(DataSet ds)
        {
            connectDatabase();
            var select = "SELECT * FROM Asiakastiedot";
            var c = connect;
            var dataAdapter = new SqlDataAdapter(select, c);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            ds.Tables.Add("Asiakastiedot");
            dataAdapter.Fill(ds, "Asiakastiedot");
            disconnectDatabse();
            return ds;
        }
    }
}
