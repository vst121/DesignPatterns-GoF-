using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class EncryptedCloudStream : IStream
    {
        IStream stream;

        public EncryptedCloudStream(IStream stream)
        {
            this.stream = stream;
        }

        public void Write(string data)
        {
            var encrypt = "#G*GH%**%*^$^$&";
            stream.Write(encrypt);
        }
    }
}
