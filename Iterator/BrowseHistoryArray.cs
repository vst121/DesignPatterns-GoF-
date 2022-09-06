using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class BrowseHistoryArray
    {
        private int count;
        public BrowseHistoryArray()
        {
            Urls = new string[5];
            count = 0;
        }

        public void Push(string url)
        {
            Urls[count++] = url;
        }

        public string Pop()
        {
            return Urls[--count];
        }

        public string[] Urls { get; private set; }

        public IIterator CreateIterator()
        {
            return new ArrayIterator(this);
        }
    }

}
