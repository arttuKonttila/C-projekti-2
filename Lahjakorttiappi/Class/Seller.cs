using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lahjakorttiappi.Class
{
    public class Seller
    {
        int id;
        public int ID { get {return id; } set {id = value; } }

        string myyja;
        public string Myyja { get { return myyja; } set {myyja = value; } }
    }
}
