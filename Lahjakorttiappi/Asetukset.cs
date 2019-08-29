using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Xml;

namespace Lahjakorttiappi
{
    public partial class Asetukset : Form
    {
        static string logoName = "logo.jpg";
        string path = Path.Combine(Environment.CurrentDirectory, @"Pictures\", logoName);
        string companyData = "data/contact.xml";
        string companyLogo = "data/image/logo.jpg";
        public Asetukset()
        {
            InitializeComponent();
            loadCompanyInfo();
            loadLogo();
        }

        private void loadCompanyInfo()
        {
            

            DataSet read = new DataSet();
            read.ReadXml(companyData);

            foreach (DataRow dr in read.Tables[0].Rows)
            {
                txtBoxFirmName.Text = dr["CompanyName"].ToString().Trim();
                txtBoxIdentifier.Text = dr["CompanyID"].ToString().Trim();
                txtBoxAdress.Text = dr["Address"].ToString().Trim();
                txtBoxPostNumber.Text = dr["PostalNumber"].ToString().Trim();
                txtBoxPostState.Text = dr["PostalState"].ToString().Trim();
                txtBoxPhone.Text = dr["Phone"].ToString().Trim();
                txtBoxEmail.Text = dr["Email"].ToString().Trim();
                txtBoxWeb.Text = dr["WebSite"].ToString().Trim();
            }   
            
        } 

        private void txtBoxIdentifier_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblOpenTiime_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddLogo_Click(object sender, EventArgs e)
        {
           
            //Gets file from user to use as logo
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = @"C:\";
            open.Title = "Lisää logo";
            open.DefaultExt = "jpg";
            open.CheckFileExists = true;
            open.CheckPathExists = true;
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png";
           
            if (open.ShowDialog() == DialogResult.OK)
            {

                // Sets loaded image to pictureBox
                logoBox.Image = new Bitmap (open.FileName);
                //Saves the image to image folder
                logoBox.Image.Save(companyLogo);
               
            }
            else
            {
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            textBoxEmptyTest();
            writeDataToXml();

        }
        private void textBoxEmptyTest()
        {
            //Basic info message if some or all TextBoxes are empty
            string ilmoitus = "Ole hyvä ja täytä kentät: ";
            string tulokset;
            bool kytkin = true;
            //Go over every TextBox in PnInfo panel. 
            foreach (TextBox testattava in PnInfo.Controls.OfType<TextBox>())
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

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            Tuotteet Products = new Tuotteet();
            Products.ShowDialog();
        }
        // Loads logo.jpg to logoBox ImageBox if its greated
        private void loadLogo()
        {
            if (File.Exists(companyLogo))
                {
                logoBox.ImageLocation = companyLogo;
                }           
        }

        //Remove logo from images folder 
        private void btnRemoveLogo_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Haluatko varmasti poistaa logon? ","Tämä poistaa logon lopullisesti", MessageBoxButtons.YesNo);
            if (delete == DialogResult.Yes)
            {

                File.Delete(companyLogo);
                if (!File.Exists(companyLogo))
                {
                    MessageBox.Show("Logo poistettu");
                    logoBox.Dispose();
                }
                else
                {
                    MessageBox.Show("Logoa ei poistettu");
                }
            }
            
        }
        //Write TextBox text to xlm file to use later
        private void writeDataToXml()
        {
            
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
            xmlWriterSettings.Indent = true;
            xmlWriterSettings.NewLineOnAttributes = true;
            using (XmlWriter create =XmlWriter.Create(companyData, xmlWriterSettings))
                    {
                        create.WriteStartDocument();
                        create.WriteStartElement ("Company");
                        create.WriteElementString("CompanyName",txtBoxFirmName.Text);
                        create.WriteElementString ("CompanyID",txtBoxIdentifier.Text);
                        create.WriteElementString ("Address",txtBoxAdress.Text);
                        create.WriteElementString("PostalNumber",txtBoxPostNumber.Text);
                        create.WriteElementString("PostalState",txtBoxPostState.Text);
                        create.WriteElementString ("Phone",txtBoxPhone.Text);
                        create.WriteElementString("Email",txtBoxEmail.Text);
                        create.WriteElementString("WebSite",txtBoxWeb.Text);
                        create.WriteEndElement();
                        create.WriteEndDocument();
                        create.Flush();
                   }           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult remove = MessageBox.Show("Haluatko varmasti poistaa yrityksen tiedot? ", "Tämä poistaa tiedot lopullisesti", MessageBoxButtons.YesNo);
            if (remove == DialogResult.Yes)
            {

                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.Indent = true;
                xmlWriterSettings.NewLineOnAttributes = true;

                using (XmlWriter create = XmlWriter.Create(companyData, xmlWriterSettings))
                {
                    create.WriteStartDocument();
                    create.WriteStartElement("Company");
                    create.WriteElementString("CompanyName", "");
                    create.WriteElementString("CompanyID", "");
                    create.WriteElementString("Address", "");
                    create.WriteElementString("PostalNumber", "");
                    create.WriteElementString("PostalState", "");
                    create.WriteElementString("Phone", "");
                    create.WriteElementString("Email", "");
                    create.WriteElementString("WebSite", "");
                    create.WriteEndElement();
                    create.WriteEndDocument();
                    create.Flush();
                }
                foreach (TextBox clear in PnInfo.Controls.OfType<TextBox>())
                {
                    clear.Text = "";

                }
            }
        }
    }
}
