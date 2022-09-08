using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Materials
{
    public class MaterialButton : IButton
    {
        void IWidget.Render()
        {
            Console.WriteLine("Material Button ...");
        }
    }
}
