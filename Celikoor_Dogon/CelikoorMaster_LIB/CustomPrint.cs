using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Drawing.Printing;


namespace CelikoorMaster_LIB
{
    public class CustomPrint
    {
        private Font fontType;
        private StreamReader printToFile;
        private float marginLeft, marginRight, marginTop, marginButtom;

        public CustomPrint(Font fontType, string pathToFile, float marginLeft, float marginRight, float marginTop, float marginButtom)
        {
            FontType = fontType;
            PrintToFile = new StreamReader(pathToFile);
            MarginLeft = marginLeft;
            MarginRight = marginRight;
            MarginTop = marginTop;
            MarginButtom = marginButtom;
        }

        public Font FontType { get => fontType; set => fontType = value; }
        public StreamReader PrintToFile { get => printToFile; set => printToFile = value; }
        public float MarginLeft { get => marginLeft; set => marginLeft = value; }
        public float MarginRight { get => marginRight; set => marginRight = value; }
        public float MarginTop { get => marginTop; set => marginTop = value; }
        public float MarginButtom { get => marginButtom; set => marginButtom = value; }

        public void PrintText(object sender, PrintPageEventArgs e)
        {
            float tinggiFont = FontType.GetHeight(e.Graphics);
            float y;
            float x = MarginLeft;
            int jumBarisSaatIni = 0;
            int maxBarisDalamHalaman = (int)((e.MarginBounds.Height - MarginTop - MarginButtom) / tinggiFont);
            string textCetak = PrintToFile.ReadLine();
            while (jumBarisSaatIni < maxBarisDalamHalaman && textCetak != null)
            {
                y = MarginTop + (jumBarisSaatIni * tinggiFont);
                e.Graphics.DrawString(textCetak, FontType, Brushes.Black, x, y);
                jumBarisSaatIni++;
                textCetak = PrintToFile.ReadLine();
            }
            if (textCetak != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }
        public void SendToPrinter()
        {
            PrintDocument p = new PrintDocument();
            p.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            p.PrintPage += new PrintPageEventHandler(PrintText);
            p.Print();
            PrintToFile.Close();
        }
    }
}
