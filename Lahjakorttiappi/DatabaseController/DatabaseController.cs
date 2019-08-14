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
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Lahjakortti;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //string connectionString = @"Data Source=|DataDirectory|\Lahjakortti.mdf";
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
            ds.Tables.Add("CustomerInfo");
            dataAdapter.Fill(ds, "CustomerInfo");
            disconnectDatabse();
            return ds;
        }

        public void addProduct(Class.Products prod)
        {
            connectDatabase();
            SqlCommand cmd = new SqlCommand("INSERT INTO [Palvelut]([Palvelu]) VALUES @Palvelu");
            cmd.Parameters.AddWithValue("@Palvelu", prod.Palvelu);
        }
    }
}
