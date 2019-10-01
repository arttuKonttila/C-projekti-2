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
    public partial class HallitseHenkilokuntaa : Form
    {
        DatabaseController.DatabaseController dBController = new DatabaseController.DatabaseController();
        DataSet ds = new DataSet();
        public HallitseHenkilokuntaa()
        {
            InitializeComponent();
        }

        private void BtnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRemoveStaff_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddStaff_Click(object sender, EventArgs e)
        {
            Class.Seller seller = new Class.Seller();
            seller.Myyja = txtBoxNameStaff.Text;
            
        }
    }
}
