using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class SamsungTV : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Samsung Turn On ...");
        }
        
        public void TurnOff()
        {
            Console.WriteLine("Samsung Turn Off ...");
        }
        public void SetChannel(int number)
        {
            Console.WriteLine("Samsung Set Channel: {0} ...", number);
        }
    }
}
