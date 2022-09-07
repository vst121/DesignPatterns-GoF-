using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class CaramelFilter : IFilter
    {
        Caramel caramel;

        public CaramelFilter(Caramel caramel)
        {
            this.caramel = caramel;
        }

        public void Apply(Image image)
        {
            caramel.Init();
            caramel.Render();
        }
    }
}
