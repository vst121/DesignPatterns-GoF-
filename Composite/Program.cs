using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var group1 = new Group();
            group1.Add(new Shape());
            group1.Add(new Shape());

            var group2 = new Group();
            group2.Add(new Shape());

            var group = new Group();
            group.Add(group1);
            group.Add(group2);

            group.Render();
            group.Move();

            Console.ReadLine();
        }
    }
}
