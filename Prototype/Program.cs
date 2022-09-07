using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var contextMenu = new ContextMenu();
            var circle1 = new Circle(10);
            var circle2 = new Circle(20);
            var square1 = new Sqaure(30);

            dynamic clonedCircle1 = contextMenu.Duplicate(circle1);
            dynamic clonedCircle2 = contextMenu.Duplicate(circle2);
            dynamic clonedSqaure1 = contextMenu.Duplicate(square1);

            Console.WriteLine("1st Cloned Component is a Circle with Radius of : {0} ", clonedCircle1.Radius);
            Console.WriteLine("2nd Cloned Component is a Circle with Radius of : {0} ", clonedCircle2.Radius);
            Console.WriteLine("3rd Cloned Component is a Sqaure with Width of : {0} ", clonedSqaure1.Width);

            Console.ReadLine();
        }
    }
}
