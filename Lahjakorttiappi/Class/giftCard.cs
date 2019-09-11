using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lahjakorttiappi.Class
{
    public class giftCard
    {
        private int id;
        private DateTime voimassaolo;
        private string myyja;
        public int ID { get {return id; } set {id = value; } }
        public DateTime Voimassaolo { get {return voimassaolo; } set {voimassaolo = value; } }
        public string Myyja { get {return myyja; } set {myyja = value; } }
    }
}
