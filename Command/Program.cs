using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new CustomerService();
            var command = new AddCustomerCommand(service);
            var button = new Button(command);

            button.Click();

            Console.ReadLine();
        }
    }
}
