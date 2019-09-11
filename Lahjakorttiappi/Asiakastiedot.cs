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
        DatabaseController.DatabaseController dBController = new DatabaseController.DatabaseController();
        DateTime sellTime = new DateTime();
        public Class.Asiakastiedot customerInfo = new Class.Asiakastiedot();
        public Class.giftCard giftCard = new Class.giftCard();
        public Class.Orders order = new Class.Orders();
        public DateTime SellTime()
        {
            sellTime = dtmSellTime.Value;
            return sellTime;
        }

        public AsiakasTiedot()
        {
            InitializeComponent();
            List<Class.Products> allProducts = new List<Class.Products>();
            allProducts = dBController.bringProducts();
            cmBoxService.DataSource = allProducts;
            cmBoxService.DisplayMember = "Palvelu";
            cmBoxService.ValueMember = "PalveluNro";
        }


        //saves the data from text fields into a public string format so that i can be utilized in the main form
        public void saveInfo()
        {
            
            try
            {
                customerInfo.AsiakasNro = Convert.ToInt32(lblIDShow.Text);
            }
            catch
            {

            }
            customerInfo.Etunimi = txtBoxFirstName.Text;
            customerInfo.Sukunimi = txtBoxLastName.Text;
            customerInfo.PuhNro = txtBoxPhone.Text;
            customerInfo.Sahkoposti = txtBoxEmail.Text;
            customerInfo.Postinumero = txtBoxPoNbr.Text;
            customerInfo.Paikka = txtBoxPoPlace.Text;
            customerInfo.Adress = TxtBoxAdress.Text;
            customerInfo.PalveluID = Convert.ToInt32(cmBoxService.SelectedValue);

            giftCard.Myyja = cmBoxSeller.Text;
            giftCard.Voimassaolo = dtmExpirationDate.Value;
            order.Pvm = dtmSellTime.Value;
            order.Usages = cmBoxTime.Text;
            if(paidCheckBox.Checked == true)
            {
                order.Paid = 1;
            }
            else
            {
                order.Paid = 0;
            }
            dBController.addCustomerData(info, giftCard, order);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           //Tähän olisi hyvä laittaa kyselyä varmistamaan sulkeminen ja siitä jos ei ole tallennettu tietoja niin haluaako käyttäjä tallentaa

            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            textBoxEmptyTest();
            saveInfo();
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
