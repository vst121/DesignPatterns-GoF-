using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Materials
{
    public class MaterialWidgetFactory : IWidgetFactory
    {
        public IButton createButton()
        {
            return new MaterialButton();
        }

        public ITextBox createTextBox()
        {
            return new MaterialTextBox();
        }
    }
}
