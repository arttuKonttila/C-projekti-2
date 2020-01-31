using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lahjakorttiappi
{
    public partial class HallitseAikoja : Form
    {
        DatabaseController.DatabaseController dbController = new DatabaseController.DatabaseController();
        public HallitseAikoja()
        {
            InitializeComponent();
        }

     

        private void BtnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addTime()
        {
            Class.Orders order = new Class.Orders();
            order.Duration = textTimeBox.Text;
            dbController.addTime(order.Duration);
        }
    }
}
