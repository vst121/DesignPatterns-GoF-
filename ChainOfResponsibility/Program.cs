using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // Authenticator -> Logger -> Compressor
            var compressor = new Compressor(null);
            var logger = new Logger(compressor);
            var authenticator = new Authenticator(logger);
            var server = new WebServer(authenticator);

            server.Handle(new HttpRequest("Admin", "123"));


            Console.ReadLine();
        }
    }
}
