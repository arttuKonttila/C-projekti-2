using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lahjakorttiappi.Class
{
    public class Orders
    {
        private int id;
        public int ID { get { return id; } set { id = value; } }

        private DateTime pvm;
        public DateTime Pvm { get { return pvm; } set { pvm = value; } }

        private string duration;
        public string Duration { get { return duration; } set { duration = value; } }

        private string usages;
        public string Recipient { get { return recipient; } set { recipient = value; } }

        private string recipient;
        public string Usages { get { return usages; } set { usages = value; } }

        private int paid;
        public int Paid { get { return paid; } set { paid = value; } }
    }
}
