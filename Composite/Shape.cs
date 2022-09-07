using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Shape : IComponent
    {
        public void Render()
        {
            Console.WriteLine("Render Shape ...");
        }
        public void Move()
        {
            Console.WriteLine("Move Shape ...");
        }
    }
}
