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
    public partial class Paaikkuna : Form
    {
        DatabaseController.DatabaseController dBController = new DatabaseController.DatabaseController();
        DataSet ds = new DataSet();
        public Paaikkuna()
        {
            InitializeComponent();
            loadData();
        }

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            AsiakasTiedot lisaa = new AsiakasTiedot();
            lisaa.ShowDialog();
            var dialogResult = lisaa.DialogResult;

            //saves the text field data into the database
            if(dialogResult == DialogResult.OK) 
            {
                try
                {
                    Class.Asiakastiedot info = new Class.Asiakastiedot();
                    info = lisaa.getCustomerInfo();
                    dBController.changeCustomerInfo(info);
                }
                catch
                {

                }
            }
            else
            {
                return;
            }
        }

        private void loadData()
        {

            dBController.bringAllData(ds);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "CustomerInfo";
        }

        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dynamic result = MessageBox.Show("Haluatko lopettaa ohjelman?", "Lopeta", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            AsiakasTiedot Lisaa = new AsiakasTiedot();
            Lisaa.ShowDialog();
        }

        private void asetuksetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asetukset Asetukset = new Asetukset();
            Asetukset.ShowDialog();
        }

        private void lisääUusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsiakasTiedot Lisaa = new AsiakasTiedot();
            Lisaa.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                try
                {
                    int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                    dBController.removeById(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                dataGridView1.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Valitse poistettava rivi");
                return;
            }
        }
    }
    }
}
