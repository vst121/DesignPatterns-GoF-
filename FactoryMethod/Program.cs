using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            new ProductsController().ListProducts();

            Console.ReadLine();
        }
    }
}
