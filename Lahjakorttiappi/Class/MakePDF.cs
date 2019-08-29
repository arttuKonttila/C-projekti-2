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



namespace Lahjakorttiappi.DatabaseController
{
    public class MakePDF
    {
        string Desitination = "/data/lahjakortit/lahjakortti.pdf";
        string logo = "data/image/logo.jpg";

        public virtual void CreatePDF (string Destination)
        {
            PdfWriter writer = new PdfWriter(Desitination);
            PdfDocument pdf = new PdfDocument(writer);
            Document dokumentti = new Document(pdf, PageSize.A4.Rotate());
            PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

        }


    }
}
