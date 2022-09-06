using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class BrushTool : Tool
    {
        public void MosueDown()
        {
            Console.WriteLine("Brush Icon");

        }

        public void MosueUp()
        {
            Console.WriteLine("Draw a line");
        }
    }
}
