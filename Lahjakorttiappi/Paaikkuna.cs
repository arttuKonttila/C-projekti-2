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
        public Paaikkuna()
        {
            InitializeComponent();
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
    }
}
