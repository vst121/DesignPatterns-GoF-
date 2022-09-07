using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class DefaultController
    {
        public void Render(string viewName, Dictionary<string, object> context)
        {
            var engine = CreateViewEngine();
            var html = engine.Render(viewName, context);
            Console.WriteLine(html);
        }

        protected virtual IViewEngine CreateViewEngine()
        {
            return new DefaultViewEngine();
        }
    }
}
