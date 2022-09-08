using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ant
{
    public class AntTextBox : ITextBox
    {
        void IWidget.Render()
        {
            Console.WriteLine("Ant Text Box ...");
        }
    }
}
