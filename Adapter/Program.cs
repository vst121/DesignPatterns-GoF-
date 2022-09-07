using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageView = new ImageView(new Image());

            imageView.Apply(new VividFilter());
            imageView.Apply(new CaramelFilter(new Caramel()));

            Console.ReadLine();
        }
    }
}
