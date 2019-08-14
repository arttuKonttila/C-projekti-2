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
        
        //fills product screen with product info
        public DataSet bringProductInfo(DataSet ds)
        {
            connectDatabase();
            var select = "SELECT * FROM Palvelut";
            var c = connect;
            var dataAdapter = new SqlDataAdapter(select, c);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            ds.Tables.Add("ProductInfo");
            dataAdapter.Fill(ds, "ProductInfo");
            disconnectDatabse();
            return ds;
        }

        //saves the product to database
        public void addProduct(Class.Products prod)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [Palvelut]([Palvelu]) VALUES (@Palvelu)", connect);
            cmd.Parameters.AddWithValue("@Palvelu", prod.Palvelu);
            connectDatabase();
            using(cmd)
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    disconnectDatabse();
                }
                catch(Exception ex)
                {
                    disconnectDatabse();
                    //merkintä logiin tai jtn vastaavaa
                }
            }
            disconnectDatabse();
        }

        public void changeCustomerInfo(Class.Asiakastiedot info)
        {

        }
    }
}
