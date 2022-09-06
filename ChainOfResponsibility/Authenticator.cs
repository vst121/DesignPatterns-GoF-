using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            var isValid = (request.UserName == "Admin" && request.Password == "123");

            Console.WriteLine("Authenticate ...");
            return !isValid;
        }
    }
}
