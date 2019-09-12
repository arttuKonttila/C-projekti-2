using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.IO.Font.Constants;
using iText.IO.Util;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Image;
using System.IO;
using System.Data;




namespace Lahjakorttiappi.Class

{
    public class MakePDF
    {
        public const String pdfDest = "/data/lahjakortit/lahjakortti.pdf";
        public const String logo = "data/image/logo.jpg";
        AsiakasTiedot parent;

        public void Main(AsiakasTiedot kutsuvaLomake)
        {
            parent = kutsuvaLomake;
            FileInfo file = new FileInfo(pdfDest);
            file.Directory.Create();
            new MakePDF().CreatePdf(pdfDest);
        }


        public virtual void CreatePdf (String pdfDest)
        {
            string pdfDestination = System.IO.Path.Combine(Environment.CurrentDirectory, "data/lahjakorttit/lahjakortti.pdf");
            //string pdfBackground = System.Reflection.Assembly.GetExecutingAssembly(giftCardBack.jpg);
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, "data/image/logo.jpg");
            string logoDest = path; // (@"/data/image/logo.jpg");
            string companyData = System.IO.Path.Combine(Environment.CurrentDirectory, "data/contact.xml");
            string customer = parent.customerInfo.Etunimi + " " + parent.customerInfo.Sukunimi;
            string service = parent.customerInfo.TilausID + " " + parent.customerInfo.PalveluAika + parent.customerInfo.PalveluMaara + " kertaa";
            string date = "Lahjakortti on voimassa " + parent.SellTime().ToString() + " vuoden eteenpäin.";
            string company = "", cmAddress = "", cmEmail = "", cmPhone = "", cmPostNum = "", cmPostState = "", cmWeb = "";
            // var kuva = Properties.Resources.giftCardBack.RawFormat;
            // System.Drawing.Image image = Properties.Resources.giftCardBack;
            // iText.Layout.Element.Image background = Properties.Resources.giftCardBack;
            // System.Drawing.im
            //iText.Layout.Element.Image background = new iText.Layout.Element.Image(ImageDataFactory.Create(pdfBackground));
            iText.Layout.Element.Image logo = new iText.Layout.Element.Image(ImageDataFactory.Create(logoDest));
            DataSet read = new DataSet();
            read.ReadXml(companyData);

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


            PdfDocument pdf = new PdfDocument(new PdfWriter(pdfDestination));

            PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            Document dokumentti = new Document(pdf, PageSize.A4.Rotate());

            //dokumentti.Add(background);
            Paragraph h1 = new Paragraph("LAHJAKORTTI").SetBold().SetFont(font).SetFontSize(35);
            Paragraph hello = new Paragraph("Hei " + customer).SetFont(font).SetFontSize(20);
            Paragraph body = new Paragraph("Sinulla on lahjakortti" + service).SetFont(font).SetFontSize(18);
            Paragraph valid = new Paragraph(date).SetFont(font).SetFontSize(16);
            Paragraph companyInfo = new Paragraph(company + "/n" + cmAddress + "/n" + cmPostNum + " " + cmPostState + "/n" + cmPhone + "/n" + cmEmail + "/n" + cmWeb).SetFont(font).SetFontSize(12);
            // Tryed to get the paragraph to be accessible.
            //h1.getAccessibilityProperties().setRole(StandardRoles.H1);
            dokumentti.Add(h1);
            dokumentti.Add(logo);
            dokumentti.Add(h1);
            dokumentti.Add(hello);
            dokumentti.Add(body);
            dokumentti.Add(valid);
            dokumentti.Add(companyInfo);
            dokumentti.Close();
        }

    }


    
}
