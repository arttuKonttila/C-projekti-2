using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.IO.Util;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout.Renderer;
using iText.Kernel.Utils;



namespace Lahjakorttiappi
{
    public partial class AsiakasTiedot : Form
    {
        public AsiakasTiedot()
        {
            InitializeComponent();
            products = dbController.bringProducts();
            cmBoxService.DataSource = products;
            cmBoxService.DisplayMember = "Palvelu";
            cmBoxService.ValueMember = "PalveluNro";
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
            info.PalveluID = Convert.ToInt32(cmBoxService.SelectedValue);
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
            dbController.addCustomerInfo(customer);
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


            
            string pdfDestination = ("/data/lahjakorttit/lahjakortti.pdf ");
            string pdfBackground = ("/Resources/giftCardBack.jpg");
            string logoDest = ("/data/logo.jpg");
            
            string customer = txtBoxFirstName.Text + " " + txtBoxLastName.Text;
            string service = cmBoxService.SelectedItem.ToString() + " " + cmBoxTime.SelectedItem.ToString() + " " + numAmount.Value.ToString()+ " kertaa" ;
            string date = "Lahjakortti on voimassa "+ dtmSellTime.Value.ToString()+ " vuoden eteenpäin.";        

            // var kuva = Properties.Resources.giftCardBack.RawFormat;
            // System.Drawing.Image image = Properties.Resources.giftCardBack;
            // iText.Layout.Element.Image background = Properties.Resources.giftCardBack;
            // System.Drawing.im
            iText.Layout.Element.Image background = new iText.Layout.Element.Image(ImageDataFactory.Create(pdfBackground));
            iText.Layout.Element.Image logo = new iText.Layout.Element.Image(ImageDataFactory.Create(logoDest));
            
            PdfWriter writer = new PdfWriter(pdfDestination);
            PdfDocument pdf = new PdfDocument(writer);
            PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            Document dokumentti = new Document(pdf, PageSize.A4.Rotate());
           
            dokumentti.Add(background);
            Paragraph h1 = new Paragraph("LAHJAKORTTI").SetBold().SetFont(font).SetFontSize(35);
            Paragraph hello = new Paragraph("Hei " + customer).SetFont(font).SetFontSize(20);
            Paragraph body = new Paragraph("Sinulla on lahjakortti" + service).SetFont(font).SetFontSize(18);
            Paragraph valid = new Paragraph(date).SetFont(font).SetFontSize(16);
            // Tryed to get the paragraph to be accessible.
            //h1.getAccessibilityProperties().setRole(StandardRoles.H1);
            dokumentti.Add(h1);
            dokumentti.Add(logo);
            dokumentti.Add(h1);
            dokumentti.Add(hello);
            dokumentti.Add(body);
            dokumentti.Add(valid);
            
            dokumentti.Close();
          
        }
    }
}
