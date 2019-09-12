using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.IO.Font.Constants;
using iText.IO.Image;
using System.IO;
using iText.IO.Util;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout.Renderer;
using iText.Kernel.Utils;
using Image = System.Drawing.Image;


namespace Lahjakorttiappi
{
    public partial class AsiakasTiedot : Form
    {
        DatabaseController.DatabaseController kanta = new DatabaseController.DatabaseController();
        DateTime sellTime = new DateTime();
        public Class.Asiakastiedot info = new Class.Asiakastiedot();

        public DateTime SellTime()
        {
            sellTime = dtmSellTime.Value;
            return sellTime;
        }

        public AsiakasTiedot()
        {
            InitializeComponent();
            List<Class.Products> allProducts = new List<Class.Products>();
            allProducts = kanta.bringProducts();
            cmBoxService.DataSource = allProducts;
            cmBoxService.DisplayMember = "Palvelu";
            cmBoxService.ValueMember = "PalveluNro";
        }


        //saves the data from text fields into a public string format so that i can be utilized in the main form
        public Class.Asiakastiedot getCustomerInfo()
        {
            
            try
            {
                info.AsiakasNro = Convert.ToInt32(lblIDShow.Text);
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
            info.PalveluID = Convert.ToInt32(cmBoxService.SelectedValue);
            info.PalveluAika = Convert.ToInt32(cmBoxTime.SelectedValue);
            info.PalveluMaara = Convert.ToInt32(numAmount.Value);
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
            Class.Asiakastiedot customer = new Class.Asiakastiedot();
            customer = getCustomerInfo();
            kanta.addCustomerInfo(customer);
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

        private void BtnSend_Click(object sender, EventArgs e)
        {
            textBoxEmptyTest();
            Class.MakePDF tuloste = new Class.MakePDF();
            tuloste.Main(this);
            
        }

       

       
    }
}
