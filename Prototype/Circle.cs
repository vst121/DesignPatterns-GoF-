using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Circle : IComponent
    {
        public Circle(int radius)
        {
            Radius = radius;
        }
        public IComponent Clone()
        {
            Circle newCircle = new Circle(Radius);
            return newCircle;
        }

        public void Render()
        {
            Console.WriteLine("Rendering a Circle ...");
        }

        public int Radius { get; private set; }

    }
}
