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
            var select = @"SELECT aTied.ID, aTied.Etunimi, aTied.Sukunimi, aTied.Osoite, aTied.PuhNro, aTied.Sahkoposti, aTied.Postinumero, aTied.Paikka, lahj.Voimassaolo, lahj.Myyjä, palv.Palvelu, til.PVM, til.Kerrat, til.Kesto, til.Maksettu, til.Saaja
                        FROM [Asiakastiedot] as aTied
                        INNER JOIN[Palvelut] as palv
                        ON aTied.PalveluID = palv.ID
                        INNER JOIN [Tilaukset] til
                        ON aTied.TilausID = til.ID
                        INNER JOIN [Lahjakortti] as lahj
                        ON aTied.LahjakorttiID = lahj.ID";
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

        /*public DataSet bringProductsOnly(DataSet ds)
        {
            connectDatabase();
            var select = "SELECT * FROM Palvelut";
            var c = connect;
            var dataAdapter = new SqlDataAdapter(select, c);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Fill(ds, "ProductInfo");
            disconnectDatabse();
            return ds;
        }*/

        //removes products from database
        public void removeProductById(int id)
        {
            connectDatabase();
            SqlCommand cmd = new SqlCommand("DELETE FROM Palvelut WHERE ID = @id", connect);
            cmd.Parameters.AddWithValue("@id", id);
            using(cmd)
            {
                cmd.ExecuteNonQuery();
                
            }
            disconnectDatabse();
    }

        //removes Customer Info from database
        public void removeCustomerInfoById(int id)
        {
            List<int> CustomerInfoId = new List<int>();
            connectDatabase();

            //bring the ids from customerinfo table so we can utilize them to delete data from all the tables
            SqlCommand command = new SqlCommand(@"SELECT PalveluID, TilausID, LahjakorttiID
                                            FROM [Asiakastiedot]
                                            WHERE ID = @id" , connect);
            command.Parameters.AddWithValue("@id", id);
            SqlDataReader read = command.ExecuteReader();
            if(read.HasRows)
            {
                while(read.Read())
                {
                    CustomerInfoId.Add(Convert.ToInt32(read.GetValue(0)));
                    CustomerInfoId.Add(Convert.ToInt32(read.GetValue(1)));
                    CustomerInfoId.Add(Convert.ToInt32(read.GetValue(2)));
                }
            }
            read.Close();
            SqlCommand cmd = new SqlCommand("DELETE FROM Asiakastiedot WHERE ID = @id", connect);
            cmd.Parameters.AddWithValue("@id", id);
            using (cmd)
            {
                cmd.ExecuteNonQuery();

            }
            SqlCommand deletePalvelu = new SqlCommand("DELETE FROM Palvelut WHERE ID = @id", connect);
            deletePalvelu.Parameters.AddWithValue("@id", CustomerInfoId[0]);
            using(deletePalvelu)
            {
                deletePalvelu.ExecuteNonQuery();
            }
            SqlCommand deleteTilaukset = new SqlCommand("DELETE FROM Tilaukset WHERE ID = @id", connect);
            deleteTilaukset.Parameters.AddWithValue("@id", CustomerInfoId[1]);
            using(deleteTilaukset)
            {
                deleteTilaukset.ExecuteNonQuery();
            }
            SqlCommand deleteLahjakortti = new SqlCommand("DELETE FROM Lahjakortti WHERE ID = @id", connect);
            deleteLahjakortti.Parameters.AddWithValue("@id", CustomerInfoId[2]);
            using(deleteLahjakortti)
            {
                deleteLahjakortti.ExecuteNonQuery();
            }
            disconnectDatabse();
        }

        //saves the product to database
        public bool addProduct(Class.Products prod)
        {
            bool error = false;
            SqlCommand cmd = new SqlCommand("INSERT INTO [Palvelut]([Palvelu]) VALUES (@Palvelu)", connect);
            cmd.Parameters.AddWithValue("@Palvelu", prod.Palvelu);
            connectDatabase();
            using (cmd)
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    disconnectDatabse();
                }
                catch (Exception ex)
                {
                    disconnectDatabse();
                    error = true;
                    //merkintä logiin tai jtn vastaavaa
                }
            }
            if(error == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void changeCustomerInfo(Class.Asiakastiedot info)
        {

        }

        public void addCustomerInfo(Class.Asiakastiedot info)
        {

        }
    }
}
