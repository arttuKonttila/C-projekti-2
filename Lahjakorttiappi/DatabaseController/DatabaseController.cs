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
        //luo sql yhteyden
        SqlConnection connect = new SqlConnection();
        public DatabaseController()
        {
            connect.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\Lahjakorttiappi\Lahjakortti.mdf;Integrated Security=True";
        }
        
    }
}
