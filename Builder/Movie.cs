using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Movie
    {
         public void AddFrame(string text, int duration)
         {
            Console.WriteLine("Movie Add Frame {0} for {1} seconds ...", text, duration);
         }
    }
}
