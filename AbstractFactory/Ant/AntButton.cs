using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ant
{
    public class AntButton : IButton
    {
        void IWidget.Render()
        {
            Console.WriteLine("Ant Button ...");
        }
    }
}
