using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var presentation = new Presentation();
            presentation.AddSlide(new Slide("Slide 1"));
            presentation.AddSlide(new Slide("Slide 2"));

            var builder = new PdfBuilder();
            //var builder = new MovieBuilder();
            presentation.Export(builder);

            var pdf = builder.GetPdf();
            //var movie = builder.GetMovie();
                
            Console.ReadLine();
        }
    }
}
