using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();
            string[] fileNames = { "b1", "b2", "b3" };
            foreach (var fileName in fileNames)
            {
                library.AddEBook(new EBookProxy(fileName));
              //  library.AddEBook(new RealEBook(fileName));
            }

            library.OpenEBook("b1");
            //library.OpenEBook("b2");

            Console.ReadLine();
        }
    }
}
