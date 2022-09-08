using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.App
{
    public class ContactForm
    {
        public void Render(IWidgetFactory widgetFactory)
        {
            widgetFactory.createButton().Render();
            widgetFactory.createTextBox().Render();
        }
    }
}
