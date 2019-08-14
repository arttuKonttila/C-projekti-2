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
        public Class.Asiakastiedot getCustomerInfo()
        {
            Class.Asiakastiedot info = new Class.Asiakastiedot();
            try
            {
                info.AsiakasNro = Convert.ToInt32(txtBoxID.Text);
            }
            catch
            {

            }
            info.Etunimi = txtBoxFirstName.Text;
            info.Sukunimi = txtBoxLastName.Text;
            info.PuhNro = txtBoxPhone.Text;
            info.Sahkoposti = txtBoxEmail.Text;
            info.Postinumero = txtBoxPoNbr.Text;
            info.Paikka = txtBoxPoPlace.Text;
            info.Adress = TxtBoxAdress.Text;
            return info;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           //Tähän olisi hyvä laittaa kyselyä varmistamaan sulkeminen ja siitä jos ei ole tallennettu tietoja niin haluaako käyttäjä tallentaa

            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            textBoxEmptyTest();
        }

        private void textBoxEmptyTest()
        {
            //Basic info message if 
            string ilmoitus = "Ole hyvä ja täytä kentät: ";
            string tulokset;
            bool kytkin = true;
            //Go over every TextBox in PnInfo panel. 
            foreach (TextBox testattava in pnlGiftCardByer.Controls.OfType<TextBox>())
            {
                //Test if the TextBox is empty.
                if (testattava.Text == "")
                {
                    //Gets the AccessibilityName of the TextBox for identyfying which TextBox it is
                    tulokset = testattava.AccessibleName;
                    // Adds the AccessibilityName to the ilmoitus string.
                    ilmoitus = ilmoitus + tulokset + ", ";
                    //Puts the cursor to the TextBox whits is empty
                    testattava.Select();
                    kytkin = false;

                }

            }

            if (kytkin == false)
            {
                //Shows Message box whit the TextBoxes names in seperat
                MessageBox.Show(ilmoitus);

            }

        }
    }
}
