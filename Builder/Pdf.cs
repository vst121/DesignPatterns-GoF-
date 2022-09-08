using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Pdf
    {
         public void AddPage(string text)
         {
            Console.WriteLine("PDF Add Page {0} ...", text);
         }
    }
}
