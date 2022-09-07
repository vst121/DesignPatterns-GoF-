using System;

namespace Adapter
{
    public class Caramel
    {
        public void Init()
        {
            Console.WriteLine("Caramel Filter Init ...");
        }

        internal void Render()
        {
            Console.WriteLine("Apply Caramel Filter ...");
        }
    }
}