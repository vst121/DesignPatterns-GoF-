using AbstractFactory.App;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            new ContactForm().Render(new Ant.AntWidgetFactory());
            Console.ReadLine();
        }
    }
}
