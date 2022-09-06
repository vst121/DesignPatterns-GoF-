using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class BlackAndWhiteFilter : IFilter
    {
        public void ApplyFilter(string fileName)
        {
            Console.WriteLine("Applying Black And White Filter ...");
        }
    }
}
