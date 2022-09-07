using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class SonyTV : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Sony Turn On ...");
        }
        
        public void TurnOff()
        {
            Console.WriteLine("Sony Turn Off ...");
        }
        public void SetChannel(int number)
        {
            Console.WriteLine("Sony Set Channel: {0} ...", number);
        }
    }
}
