using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            StoreCreditCard(new EncryptedCloudStream(new CompressedCloudStream(new CloudStream())));

            Console.ReadLine();
        }

        static void StoreCreditCard(IStream stream)
        {
            stream.Write("6221-0612-1411-8855");
        }
    }
}
