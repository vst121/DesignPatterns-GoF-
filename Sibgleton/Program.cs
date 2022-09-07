using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = "CourseName";
            
            var configManager1 = ConfigManager.Instance;
            configManager1.Set(key, "Design Patterns");
            Console.WriteLine(configManager1.Get(key));

            var configManager2 = ConfigManager.Instance;
            Console.WriteLine(configManager2.Get(key));

            Console.ReadLine();
        }
    }
}
