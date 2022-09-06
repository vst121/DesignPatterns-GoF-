using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class SelectionTool : ITool
    {
        public void MosueDown()
        {
            Console.WriteLine("Selection Icon");

        }

        public void MosueUp()
        {
            Console.WriteLine("Draw dashed rectangle");
        }
    }
}
