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
        DataTable dt = new DataTable();
        public HallitseHenkilokuntaa()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            ds.Reset();
            dBController.bringStaffInfo(ds);
            dgwStaffMembers.AutoGenerateColumns = true;
            dgwStaffMembers.DataSource = ds;
            dgwStaffMembers.DataMember = "Seller";      
        }

        private void loadData2()
        {
            dt.Reset();
            dBController.bringStaffInfo2(dt);
            dgwStaffMembers.AutoGenerateColumns = true;
            dgwStaffMembers.DataSource = dt;
        }

        private void BtnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRemoveStaff_Click(object sender, EventArgs e)
        {
            if (this.dgwStaffMembers.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgwStaffMembers.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgwStaffMembers.Rows[selectedRowIndex];

                try
                {
                    int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                    dBController.removeProductById(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                dgwStaffMembers.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Valitse poistettava rivi");
                return;
            }
        }

        private void BtnAddStaff_Click(object sender, EventArgs e)
        {
            Class.Seller seller = new Class.Seller();
            seller.Myyja = txtBoxNameStaff.Text;
           /* Class.Products product = new Class.Products();
            product.Palvelu = txtBoxNameStaff.Text;*/
            if (dBController.addStaff(seller) == true)
            {
                MessageBox.Show("Myyjä lisättiin onnistuneesti");
            }
            else
            {
                MessageBox.Show("Myyjän lisäyksessä tapahtui virhe");
            }
            loadData2();
        }
    }
}
