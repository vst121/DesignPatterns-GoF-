using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var task1 = new TransferMoneyTask();
            task1.Execute();

            var task2 = new GenerateReportTask();
            task2.Execute();

            Console.ReadLine();
        }
    }
}
