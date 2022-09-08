using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ant
{
    public class AntWidgetFactory : IWidgetFactory
    {
        public IButton createButton()
        {
            return new AntButton();
        }

        public ITextBox createTextBox()
        {
            return new AntTextBox();
        }
    }
}
