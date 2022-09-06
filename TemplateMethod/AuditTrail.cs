using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class AuditTrail
    {
        public AuditTrail()
        {
        }

        public void Record()
        {
            Console.WriteLine("Audit Recording ...");
        }
    }
}
