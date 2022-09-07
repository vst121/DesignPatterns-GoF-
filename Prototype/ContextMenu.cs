using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class ContextMenu
    {
        public IComponent Duplicate(IComponent component)
        {
            var newComponent = component.Clone();
            return newComponent;
        }
    }
}
