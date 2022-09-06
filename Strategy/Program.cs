using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageStorage imageStorage = new ImageStorage(
                new JpgCompressor(), new BlackAndWhiteFilter());

            imageStorage.Store("myfile");

            Console.ReadLine();
        }
    }
}
