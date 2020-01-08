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
        DatabaseController.DatabaseController dBController = new DatabaseController.DatabaseController();
        DataSet ds = new DataSet();
        //fills product gridview with product info from database
        public HallitseAikoja()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {

            dBController.bringProductInfo(ds);
            dgwTimes.AutoGenerateColumns = true;
            dgwTimes.DataSource = ds;
            dgwTimes.DataMember = "Seller";
        }

        private void BtnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
