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
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.PdfViewer.Base;
using Syncfusion.Windows.PdfViewer;
using System.Drawing.Printing;
using Syncfusion.Windows.Forms;
using Syncfusion.Pdf.Parsing;
using Microsoft.Win32;






namespace Lahjakorttiappi
{

    public partial class LahjakorttiTiedot : Form
    {
        private PrintDocument docToPrint = new PrintDocument();
        
        DatabaseController.DatabaseController dBController = new DatabaseController.DatabaseController();
        DateTime sellTime = new DateTime();
        public Class.Asiakastiedot customerInfo = new Class.Asiakastiedot();
        public Class.giftCard giftCard = new Class.giftCard();
        public Class.Orders order = new Class.Orders();
        public Class.pdfInfoclass pdfInfo = new Class.pdfInfoclass();
        Tuple<Class.Asiakastiedot, Class.giftCard, Class.Orders> tuple;
        public const String pdfDest = "/data/lahjakortit/lahjakortti.pdf";
        public const String logo = "data/image/logo.jpg";
        private string tiedostoTulostukseen;

        public DateTime SellTime()
        {
            sellTime = dtmSellTime.Value;
            return sellTime;
        }

        public LahjakorttiTiedot()
        {
            InitializeComponent();
            FileInfo file = new FileInfo(pdfDest);
            file.Directory.Create();
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

            if (Paaikkuna.muokkaaClick == true)
            {
                tuple = dBController.fetchData(Paaikkuna.muokkaaID, customerInfo, giftCard, order);
                fillData();
            }
            else
            {
                return;
            }

        }

        public void saveInfoToPdf()
        {

            try
            {
               pdfInfo.CustomerNumber= Convert.ToInt32(lblIDShow.Text);
            }
            catch
            {

            }
            pdfInfo.Firstname = txtBoxFirstName.Text;
            pdfInfo.Lastname = txtBoxLastName.Text;   
            pdfInfo.ExDate = Convert.ToString(dtmExpirationDate.Value);
            pdfInfo.Seller = Convert.ToString(cmBoxSeller.SelectedValue);
            pdfInfo.Amount = Convert.ToString(numAmountBox.Value);
            pdfInfo.Duration = Convert.ToString(kestoNumeric.Value);
          
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
            if (paidCheckBox.Checked == true)
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
            if (tuple.Item3.Paid == 1)
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

        private void MakePdf()
        {
            string pdfDestination = System.IO.Path.Combine(Environment.CurrentDirectory, "data/lahjakortit/lahjakortti.pdf");
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, "data/image/logo.jpg");
            string companyData = System.IO.Path.Combine(Environment.CurrentDirectory, "data/contact.xml");
            string customer = txtBoxFirstName.Text + " " + txtBoxLastName.Text;
            string service = "Teillä on hieronta lahjakortti:  " + kestoNumeric.Value + " minuutin hierontaa " + numAmountBox.Value + " kertaa";
            string giftCardExDate = "Lahjakortti on voimassa " + dtmExpirationDate.Value + " saakka";
            DataSet read = new DataSet();
            read.ReadXml(companyData);
            
            string company = "", cmAddress = "", cmEmail = "", cmPhone = "", cmPostNum = "", cmPostState = "", cmWeb = "";

            foreach (DataRow dr in read.Tables[0].Rows)
            {
                company = dr["CompanyName"].ToString().Trim();
                cmAddress = dr["Address"].ToString().Trim();
                cmPostNum = dr["PostalNumber"].ToString().Trim();
                cmPostState = dr["PostalState"].ToString().Trim();
                cmPhone = dr["Phone"].ToString().Trim();
                cmEmail = dr["Email"].ToString().Trim();
                cmWeb = dr["WebSite"].ToString().Trim();
            }
             string companyInfo = company + "\n" + cmAddress + "\n" + cmPostNum + cmPostState + "\n"+ cmEmail + "\n" + cmPhone + "\n" + cmWeb ;


            PdfDocument pdfTiedosto = new PdfDocument();
            
            PdfSection osa = pdfTiedosto.Sections.Add();
            osa.PageSettings.Orientation = PdfPageOrientation.Landscape;

            PdfPage sivu = osa.Pages.Add();
            pdfTiedosto.PageSettings.Margins.All = 50;
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20f, PdfFontStyle.Bold);
            sivu.Graphics.DrawString("Lahjakortti", font, PdfBrushes.Black, new PointF(10, 100));
            PdfGraphics logoPiirto = sivu.Graphics;
            PdfBitmap logo = new PdfBitmap(path);
            logoPiirto.DrawImage(logo, 40, 20);
            sivu.Graphics.DrawString(customer, font, PdfBrushes.AliceBlue, new PointF(300, 200));
            sivu.Graphics.DrawString(service, font, PdfBrushes.Black, new PointF(100, 300));
            sivu.Graphics.DrawString(giftCardExDate, font, PdfBrushes.Black, new PointF(100, 400));
            sivu.Graphics.DrawString(companyInfo, font, PdfBrushes.Black, new PointF(300, 100));
            pdfTiedosto.Save(pdfDestination);


            System.Diagnostics.Process.Start(pdfDestination);

        }

        private void Print()
        {
            
            string docToPrint = "lahjakortti.pdf";
            string pdfPath = Path.Combine(Environment.CurrentDirectory, "data/lahjakortit/");
            PrintDocument Tulostus = new PrintDocument();
            Tulostus.DocumentName = docToPrint;
            using (FileStream stream = new FileStream(pdfPath+docToPrint, FileMode.Open))
            using (StreamReader reader = new StreamReader(stream))
            {
                tiedostoTulostukseen = reader.ReadToEnd();
            }



            Tulostus.Print();
            


        }

        private void checkForReader()
        {
            RegistryKey software = Registry.LocalMachine.OpenSubKey("Software");

            if (software != null)
            {
                RegistryKey adobe = null ;

                // Try to get 64bit versions of adobe
                if (Environment.Is64BitOperatingSystem)
                {
                    RegistryKey software64 = software.OpenSubKey("Wow6432Node");

                    if (software64 != null)
                        adobe = software64.OpenSubKey("Adobe");
                }

                // If a 64bit version is not installed, try to get a 32bit version
                if (adobe == null)
                    adobe = software.OpenSubKey("Adobe");

                // If no 64bit or 32bit version can be found, chances are adobe reader is not installed.
                if (adobe != null)
                {
                    RegistryKey acroRead = adobe.OpenSubKey("Acrobat Reader");

                    if (acroRead != null)
                    {
                        string[] acroReadVersions = acroRead.GetSubKeyNames();
                        Console.WriteLine("The following version(s) of Acrobat Reader are installed: ");

                        foreach (string versionNumber in acroReadVersions)
                        {
                            Console.WriteLine(versionNumber);
                        }
                    }
                    else
                        Console.WriteLine("Adobe reader Ei ole asennettu!");
                }
                else
                    Console.WriteLine("Adobe reader is not installed!");
            }

        }


        private void BtnSend_Click(object sender, EventArgs e)
        {
            
            textBoxEmptyTest();
            MakePdf();
            //checkForReader();
            //Print();
            
            //saveInfoToPdf();
            // Class.MakePDF tuloste = new Class.MakePDF();
            //tuloste.Main(this);
            saveInfo();

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
