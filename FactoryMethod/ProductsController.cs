using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ProductsController : SharpController
    {
        public void ListProducts()
        {
            Dictionary<string, object> context = new Dictionary<string, object>();
            Render("Products.html", context);
        }
    }
}
