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
            dBController.bringAllData(ds);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Asiakastiedot";
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
                    var fName = lisaa.getFName;
                    var lName = lisaa.getLName;
                    var id = lisaa.getID;
                    var email = lisaa.getEmail;
                    var pNumber = lisaa.getPNumber;
                    var zip = lisaa.getZip;
                    var poAdress = lisaa.getPoAdress;
                    var adress = lisaa.getAdress;
                    dBController.changeCustomerInfo(fName, lName, adress, email, id, poAdress, zip, pNumber);
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
    }
}
