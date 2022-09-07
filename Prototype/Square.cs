using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Sqaure : IComponent
    {
        public Sqaure(int width)
        {
            Width = width;
        }
        public IComponent Clone()
        {
            Sqaure newSqaure = new Sqaure(Width);
            return newSqaure;
        }

        public void Render()
        {
            Console.WriteLine("Rendering a Sqaure ...");
        }

        public int Width { get; private set; }

    }
}
