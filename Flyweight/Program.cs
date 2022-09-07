using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new PointService(new PointIconFactory());
            var points = service.GetPoints();
            foreach (var point in points)
            {
                point.Draw();
            }

            Console.ReadLine();
        }
    }
}
