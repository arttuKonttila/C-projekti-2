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
    public partial class AsiakasTiedot : Form
    {
        public AsiakasTiedot()
        {
            InitializeComponent();
        }


        //saves the data from text fields into a public string format so that i can be utilized in the main form
        public string getFName
        {
            get { return txtBoxFirstName.Text; }
        }

        public string getLName
        {
            get { return txtBoxLastName.Text; }
        }

        public string getID
        {
            get { return txtBoxID.Text; }
        }

        public string getAdress
        {
            get { return TxtBoxAdress.Text; }
        }

        public string getEmail
        {
            get { return txtBoxEmail.Text; }
        }

        public string getZip
        {
            get { return txtBoxPoNbr.Text; }
        }

        public string getPoAdress
        {
            get { return txtBoxPoPlace.Text; }
        }

        public string getPNumber
        {
            get { return txtBoxPhone.Text; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           //Tähän olisi hyvä laittaa kyselyä varmistamaan sulkeminen ja siitä jos ei ole tallennettu tietoja niin haluaako käyttäjä tallentaa

            this.Close();
        }
    }
}
