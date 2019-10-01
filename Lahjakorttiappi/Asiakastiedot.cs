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
using System.IO;




namespace Lahjakorttiappi
{
    public partial class AsiakasTiedot : Form
    {
        DatabaseController.DatabaseController dBController = new DatabaseController.DatabaseController();
        DateTime sellTime = new DateTime();
        public Class.Asiakastiedot customerInfo = new Class.Asiakastiedot();
        public Class.giftCard giftCard = new Class.giftCard();
        public Class.Orders order = new Class.Orders();
        public bool muokkaaClick = false;
        public int muokkaaID = 0;
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

            List<Class.Orders> allOrders = new List<Class.Orders>();
            allOrders = dBController.getOrders();
            cmBoxDuration.DataSource = allOrders;
            cmBoxDuration.DisplayMember = "Duration";
            cmBoxDuration.ValueMember = "ID";


            if (muokkaaClick == true || muokkaaID != 0)
            {
                dBController.fetchData(muokkaaID, customerInfo, giftCard, order);
                fillData();
            }
            else
            {
                return;
            }

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
            customerInfo.Osoite = TxtBoxAdress.Text;
            customerInfo.PalveluID = Convert.ToInt32(cmBoxService.SelectedValue);

            giftCard.Myyja = cmBoxSeller.Text;
            giftCard.Voimassaolo = dtmExpirationDate.Value;
            order.Recipient = cmBoxSeller.Text;
            order.Pvm = dtmSellTime.Value;
            order.Usages = numAmountBox.Text;
            order.Duration = cmBoxDuration.Text;
            if(paidCheckBox.Checked == true)
            {
                order.Paid = 1;
            }
            else
            {
                order.Paid = 0;
            }
            dBController.addCustomerData(customerInfo, giftCard, order);
        }

        public void fillData()
        {
            lblIDShow.Text = customerInfo.AsiakasNro.ToString();
            txtBoxFirstName.Text = customerInfo.Etunimi;
            txtBoxLastName.Text = customerInfo.Sukunimi;
            txtBoxPhone.Text = customerInfo.PuhNro;
            txtBoxEmail.Text = customerInfo.Sahkoposti;
            txtBoxPoNbr.Text = customerInfo.Postinumero;
            txtBoxPoPlace.Text = customerInfo.Paikka;
            TxtBoxAdress.Text = customerInfo.Osoite;
            cmBoxService.SelectedValue = customerInfo.PalveluID;
            cmBoxDuration.SelectedValue = order.ID;
            numAmountBox.Value = Convert.ToDecimal(order.Usages);
            dtmSellTime.Value = order.Pvm;
            dtmExpirationDate.Value = giftCard.Voimassaolo;
            if(order.Paid == 1)
            {
                paidCheckBox.Checked = true;
            }
            else
            {
                paidCheckBox.Checked = false;
            }

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
            saveInfo();
            Class.MakePDF tuloste = new Class.MakePDF();
            tuloste.Main(this);
            
        }

       

       
    }
}
