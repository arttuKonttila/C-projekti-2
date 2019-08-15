using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Lahjakorttiappi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            CreateFolders();
            CreateFiles();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Paaikkuna());
        }

        static void CreateFolders()
        {
            string data = "data";
            string image = "data/image";
            
            if (!Directory.Exists(data))
            {
                try
                {
                    Directory.CreateDirectory(data);
                }
                catch (Exception e)
                {
                    MessageBox.Show("The process failed: {0}", e.ToString());
                }

            }
            if (!Directory.Exists(image))
            {
                try
                {
                    Directory.CreateDirectory(image);
                }
                catch (Exception e)
                {
                    MessageBox.Show("The process failed: {0}", e.ToString());
                }

            }
        }

        static void CreateFiles()
        {
            string companyInfo = "data/contact.xml";

            if (!File.Exists(companyInfo))
            {
                try
                {
                    using (XmlWriter.Create(companyInfo))
                    {
                        

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Virhe luotaessa contact.xml tiedostoa" + e.ToString());
                }

            }

        }
    }
}
