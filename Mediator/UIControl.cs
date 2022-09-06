using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class UIControl
    {
        protected DialogBox owner;

        public UIControl(DialogBox owner)
        {
            this.owner = owner;
        }
    }
}
