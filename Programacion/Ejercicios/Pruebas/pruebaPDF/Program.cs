using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace pruebaPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document();  // Creando fichero logico pdf

            FileStream file = new FileStream("Datos.pdf", FileMode.Create); // Creando el fichero fisico

            PdfWriter.GetInstance(doc, file); // trabajar en pdf

            doc.Open(); // abres el pdf

            Chunk c = new Chunk("Hola que tal");
            Chunk c1 = new Chunk("PEPE");           // chunck es una cadena

            Phrase p = new Phrase();
            p.Add(c);                       // phrase es un conjunto de cadenas
            p.Add(c1);
            doc.Add(p);
                
            Font f = FontFactory.GetFont("Arial", 12, BaseColor.YELLOW);        //Font modificas las caracteristicas de la fuente

            Paragraph par = new Paragraph("Este texto es una introducción a la programación de ordenadores, usando el lenguaje C#.", f);
            par.SpacingAfter = 20f;
            par.FirstLineIndent = 30f;                                      //paragraph es un conjunto de cadenas (un parrafo)
            doc.Add(par);
           
            f = FontFactory.GetFont("Arial", 12, BaseColor.RED);
            par = new Paragraph("Este texto es una introducción a la programación de ordenadores, usando el lenguaje C#.", f);
            par.SpacingAfter = 20f;
            par.FirstLineIndent = 30f;
            doc.Add(par);


            PdfPTable tabla = new PdfPTable(4);                             //pdftable es una tabla sin celdas
            PdfPCell cell = new PdfPCell(new Paragraph("hola", f));             //pdfpcell es una celda de la tabla y se añade a la tabla

            cell.HorizontalAlignment = 1;
            tabla.AddCell(cell);

            cell = new PdfPCell(new Paragraph("adios", f));
            cell.HorizontalAlignment = 1;
            tabla.AddCell(cell);

            cell = new PdfPCell(new Paragraph("coca", f));
            cell.HorizontalAlignment = 1;
            tabla.AddCell(cell);

            cell = new PdfPCell(new Paragraph("cola", f));
            cell.HorizontalAlignment = 1;
            tabla.AddCell(cell);

            doc.Add(tabla);


            PdfPTable tabla1 = new PdfPTable(4);                             //pdftable es una tabla sin celdas
            PdfPCell cell1 = new PdfPCell(new Paragraph("hola", f));             //pdfpcell es una celda de la tabla y se añade a la tabla

            cell1.HorizontalAlignment = 1;
            cell1.Colspan = 3;
            tabla1.AddCell(cell1);

            cell1 = new PdfPCell(new Paragraph("adios", f));
            cell1.HorizontalAlignment = 1;
            tabla1.AddCell(cell1);

            cell1 = new PdfPCell(new Paragraph("coca", f));
            cell1.HorizontalAlignment = 1;
            tabla1.AddCell(cell1);

            cell1 = new PdfPCell(new Paragraph("cola", f));
            cell1.HorizontalAlignment = 1;
            tabla1.AddCell(cell1);

            doc.Add(tabla1);



            doc.Close();                //cierre del pdf




            string json = "{\"nombre:\" \"pepe\", \"apellido:\" \"asd\", \"provincia:\" \"Alicante\"}";
            Console.WriteLine(json);
        }
    }
}
