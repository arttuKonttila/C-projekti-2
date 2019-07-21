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
    public partial class Lisaaminen : Form
    {
        public Lisaaminen()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           //Tähän olisi hyvä laittaa kyselyä varmistamaan sulkeminen ja siitä jos ei ole tallennettu tietoja niin haluaako käyttäjä tallentaa

            this.Close();
        }
    }
}
