using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageStorage imageStorage = new ImageStorage();

            imageStorage.Store("myfile", new JpgCompressor(), new BlackAndWhiteFilter());
            imageStorage.Store("myfile", new PngCompressor(), new BlackAndWhiteFilter());

            Console.ReadLine();
        }
    }
}
