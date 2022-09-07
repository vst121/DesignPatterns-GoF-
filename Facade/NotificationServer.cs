using System;

namespace Facade
{
    internal class NotificationServer
    {
        public NotificationServer()
        {
        }

        internal Connection Connect(string v)
        {
            Console.WriteLine("Connecting ...");
            return new Connection();
        }

        internal AuthToken Authenticate(string appID, string key)
        {
            Console.WriteLine("Authenticating: " + appID);
            return new AuthToken();
        }

        internal void Send(object authToken, string message, string target)
        {
            Console.WriteLine("Sending Message: " + message);
        }
    }
}