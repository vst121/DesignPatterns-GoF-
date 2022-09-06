using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class PlainTextOperation : IOperation
    {
        public void apply(HeadingNode heading)
        {
            Console.WriteLine("PlainText-Heading ...");
        }

        public void apply(AnchorNode anchor)
        {
            Console.WriteLine("PlainText-Anchor ...");
        }
    }
}
