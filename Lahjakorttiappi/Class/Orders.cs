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
        private DateTime pvm;
        private string duration;
        private string usages;
        private string recipient;
        private int paid;
        public int ID { get { return id; } set { id = value; } }
        public DateTime Pvm { get {return pvm; } set {pvm = value; } }
        public string Duration { get { return duration; } set { duration = value; } }
        public string Recipient { get {return recipient; } set {recipient = value; } }
        public string Usages { get {return usages; } set {usages = value; } }
        public int Paid { get {return paid; } set {paid = value; } }

    }
}
