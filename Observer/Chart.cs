using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Chart : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Chart got updated");
        }
    }
}
