using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class RemoteControl
    {
        protected IDevice device;

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public void TurnOn()
        {
            device.TurnOn();        
        }

        public void TurnOff()
        {
            device.TurnOff();
        }
    }
}
