using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class JpgCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Jpg Compressing ...");
        }
    }
}
