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
        public Asetukset()
        {
            InitializeComponent();
            loadLogo();
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
            open.Title = "Select your preferred logo";
            open.DefaultExt = "jpg";
            open.CheckFileExists = true;
            open.CheckPathExists = true;
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png";
           
            if (open.ShowDialog() == DialogResult.OK)
            {

                // Sets loaded image to pictureBox
                logoBox.Image = new Bitmap (open.FileName);
                //Saves the image to image folder
                logoBox.Image.Save("data/image/logo.jpg");
               
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
            if (File.Exists(@"data\image\logo.jpg"))
                {
                logoBox.ImageLocation = @"data\image\logo.jpg";
                }           
        }

        //Remove logo from images folder 
        private void btnRemoveLogo_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Haluatko varmasti poistaa logon? ","Tämä poistaa logon lopullisesti", MessageBoxButtons.YesNo);
            if (delete == DialogResult.Yes)
            {

                File.Delete(@"data\image\logo.jpg");
                if (!File.Exists(@"data\image\logo.jpg"))
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
            XmlTextWriter companyInfo = new XmlTextWriter(@"Data/contact.xlm" ,System.Text.Encoding.UTF8);
            companyInfo.WriteStartDocument();
            companyInfo.WriteStartElement("Company name");
            companyInfo.WriteString(txtBoxFirmName.Text);
            companyInfo.WriteEndElement();
            companyInfo.WriteStartElement("Company ID");
            companyInfo.WriteString(txtBoxIdentifier.Text);
            companyInfo.WriteEndElement();         
            companyInfo.WriteStartElement("Address");
            companyInfo.WriteString(txtBoxAdress.Text);
            companyInfo.WriteEndElement();
            companyInfo.WriteStartElement("Postal Number");
            companyInfo.WriteString(txtBoxPostNumber.Text);
            companyInfo.WriteEndElement();
            companyInfo.WriteStartElement("State");
            companyInfo.WriteString(txtBoxPostState.Text);
            companyInfo.WriteEndElement();
            companyInfo.WriteStartElement("Phone");
            companyInfo.WriteString(txtBoxPhone.Text);
            companyInfo.WriteEndElement();
            companyInfo.WriteStartElement("Email");
            companyInfo.WriteString(txtBoxEmail.Text);
            companyInfo.WriteEndElement();
            companyInfo.WriteStartElement("Web Site");
            companyInfo.WriteString(txtBoxWeb.Text);
            companyInfo.WriteEndElement();
            companyInfo.WriteStartDocument();
            companyInfo.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult remove = MessageBox.Show("Haluatko varmasti poistaa yrityksen tiedot? ", "Tämä poistaa tiedot lopullisesti", MessageBoxButtons.YesNo);
            if (remove == DialogResult.Yes)
            {

               
            }
        }
    }
}
