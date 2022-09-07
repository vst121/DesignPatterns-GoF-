using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Point
    {
        private int x;
        private int y;
        PointIcon icon;
        public Point(int x, int y, PointIcon icon)
        {
            this.x = x;
            this.y = y;
            this.icon = icon;
        }

        public void Draw()
        {
            Console.WriteLine("Draw Point at: {0} , {1} by icon of: {2}", x, y, icon.Type);
        }
    }
}
