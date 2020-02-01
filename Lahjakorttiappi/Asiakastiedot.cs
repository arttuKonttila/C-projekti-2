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
        Tuple<Class.Asiakastiedot, Class.giftCard, Class.Orders> tuple;
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

            List<Class.Seller> allSellers = new List<Class.Seller>();
            allSellers = dBController.getSellers();
            cmBoxSeller.DataSource = allSellers;
            cmBoxSeller.DisplayMember = "Myyja";
            cmBoxSeller.ValueMember = "ID";

            if(Paaikkuna.muokkaaClick == true)
            {
                tuple = dBController.fetchData(Paaikkuna.muokkaaID, customerInfo, giftCard, order);
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
            customerInfo.MyyjaID = Convert.ToInt32(cmBoxSeller.SelectedValue);

            // = cmBoxSeller.Text;
            giftCard.Voimassaolo = dtmExpirationDate.Value;
            order.Recipient = cmBoxSeller.Text;
            order.Pvm = dtmSellTime.Value;
            order.Usages = numAmountBox.Text;
            order.Duration = kestoNumeric.Value.ToString();
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
            lblIDShow.Text = tuple.Item1.AsiakasNro.ToString();
            txtBoxFirstName.Text = tuple.Item1.Etunimi;
            txtBoxLastName.Text = tuple.Item1.Sukunimi;
            txtBoxPhone.Text = tuple.Item1.PuhNro;
            txtBoxEmail.Text = tuple.Item1.Sahkoposti;
            txtBoxPoNbr.Text = tuple.Item1.Postinumero;
            txtBoxPoPlace.Text = tuple.Item1.Paikka;
            TxtBoxAdress.Text = tuple.Item1.Osoite;
            cmBoxService.SelectedValue = tuple.Item1.PalveluID;
            kestoNumeric.Value = Convert.ToDecimal(tuple.Item3.Duration);
            numAmountBox.Value = Convert.ToDecimal(tuple.Item3.Usages);
            dtmSellTime.Value = tuple.Item3.Pvm;
            dtmExpirationDate.Value = tuple.Item2.Voimassaolo;
            if(tuple.Item3.Paid == 1)
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
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                this.Close();
            }    
            else
            {
                // user clicked no
                return;
            }
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

        private void BtnManageStaff_Click(object sender, EventArgs e)
        {
            HallitseHenkilokuntaa manageStaff = new HallitseHenkilokuntaa();
            manageStaff.ShowDialog();
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                lblIDShow.Text = "";
                txtBoxFirstName.Text = "";
                txtBoxLastName.Text = "";
                txtBoxPhone.Text = "";
                txtBoxEmail.Text = "";
                txtBoxPoNbr.Text = "";
                txtBoxPoPlace.Text = "";
                TxtBoxAdress.Text = "";
                cmBoxService.SelectedValue = -1;
                kestoNumeric.Value = 0;
                numAmountBox.Value = 0;
                dtmSellTime.Value = new DateTime(1753, 1, 1);
                dtmExpirationDate.Value = new DateTime(1753, 1, 1);
                if (paidCheckBox.Checked == true)
                {
                    paidCheckBox.Checked = false;
                }
                else
                {
                    return;
                }
            }
            else
            {
                // user clicked no
                return;
            }
        }

        private void AsiakasTiedot_Load(object sender, EventArgs e)
        {

        }

        private void cmBoxDuration_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
