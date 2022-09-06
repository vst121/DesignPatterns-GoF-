using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var dialog = new ArticleDialogBox();
            dialog.SimulateUserInteraction();

            Console.ReadLine();
        }
    }
}
