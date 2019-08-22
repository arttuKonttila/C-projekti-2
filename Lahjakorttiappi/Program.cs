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
            string companyInfoxml = "data/contact.xml";

            if (!File.Exists(companyInfoxml))
            {
                try
                {
                    XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                    xmlWriterSettings.Indent= true;
                    xmlWriterSettings.NewLineOnAttributes= true;

                    using (XmlWriter create =XmlWriter.Create(companyInfoxml, xmlWriterSettings))
                    {
                        create.WriteStartDocument();
                        create.WriteStartElement ("Company");
                        create.WriteElementString("CompanyName","");
                        create.WriteElementString ("CompanyID","");
                        create.WriteElementString ("Address","");
                        create.WriteElementString("PostalNumber","");
                        create.WriteElementString("PostalState","");
                        create.WriteElementString ("Phone","");
                        create.WriteElementString("Email","");
                        create.WriteElementString("WebSite","");
                        create.WriteEndElement();
                        create.WriteEndDocument();
                        create.Flush();
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
