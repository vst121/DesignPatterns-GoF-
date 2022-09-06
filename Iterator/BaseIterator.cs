using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public interface BaseIterator
    {
        bool HasNext();
        string Current();
        void Next();
    }
}
