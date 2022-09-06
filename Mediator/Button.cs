using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Button : UIControl
    {
        private bool enabled;
        public Button(DialogBox owner) : base(owner)
        {

        }

        public bool Enabled{ 
            get => enabled;
            set
            {
                enabled = value;
                owner.Changed(this);
            }
        }
    }
}
