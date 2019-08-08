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
        }

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
           
                AsiakasTiedot Lisaa = new AsiakasTiedot();
            Lisaa.ShowDialog();
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
