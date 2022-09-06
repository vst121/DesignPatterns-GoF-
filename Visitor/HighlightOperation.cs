using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class HighlightOperation : IOperation
    {
        public void apply(HeadingNode heading)
        {
            Console.WriteLine("Highlight-Heading ...");
        }

        public void apply(AnchorNode anchor)
        {
            Console.WriteLine("Highlight-Anchor ...");
        }
    }
}
