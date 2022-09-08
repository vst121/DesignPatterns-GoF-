using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PdfBuilder : IPresentationBuilder
    {
        private Pdf document = new Pdf();

        public void AddSlide(Slide slide)
        {
            document.AddPage(slide.Text);
        }

        public Pdf GetPdf()
        {
            return document;
        }
    }
}
