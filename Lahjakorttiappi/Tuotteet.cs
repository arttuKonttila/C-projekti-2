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
    public partial class Tuotteet : Form
    {
        DatabaseController.DatabaseController dBController = new DatabaseController.DatabaseController();
        DataSet ds = new DataSet();
        //fills product gridview with product info from database
        public Tuotteet()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {

            dBController.bringProductInfo(ds);
            dGWProducts.AutoGenerateColumns = true;
            dGWProducts.DataSource = ds;
            dGWProducts.DataMember = "ProductInfo";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnLisaaTuoet_Click(object sender, EventArgs e)
        {
            Class.Products product = new Class.Products();
            product.Palvelu = txtBoxLisaaTuote.Text;
            if (dBController.addProduct(product) == true)
            {
                MessageBox.Show("Tuote lisättiin onnistuneesti");
            }
            else
            {
                MessageBox.Show("Tuotteen lisäyksessä tapahtui virhe");
            }
            ds.Tables.Remove("ProductInfo");
            loadData();
            dGWProducts.Refresh();
            dGWProducts.Update();
        }
        private void textBoxEmptyTest()
        {
            //Basic info message if 
            string ilmoitus = "Ole hyvä ja täytä kentät: ";
            string tulokset;
            bool kytkin = true;
            //Go over every TextBox in PnInfo panel. 
            foreach (TextBox testattava in pnAddProduct.Controls.OfType<TextBox>())
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
                //Shows Message box with the TextBox's names in seperate fields
                MessageBox.Show(ilmoitus);

            }

        }

        private void btnDelProduct_Click(object sender, EventArgs e)
        {
            if (this.dGWProducts.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dGWProducts.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dGWProducts.Rows[selectedRowIndex];
               
                try
                {
                    int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                    dBController.removeProductById(id);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                dGWProducts.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Valitse poistettava rivi");
                return;
            }
        }
    }
}
