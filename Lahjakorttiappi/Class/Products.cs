using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lahjakorttiappi.Class
{
    class Products
    {
        int palveluNro;
        public int PalveluNro
        {
            get { return palveluNro; }
            set { palveluNro = value; }
        }
        string palvelu;

        public string Palvelu
        {
            get { return palvelu; }
            set { palvelu = value; }
        }
    }
}
