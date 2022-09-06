using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class BrowseHistoryList
    {
        public BrowseHistoryList()
        {
            Urls = new List<string>();
        }

        public void Push(string url)
        {
            Urls.Add(url);
        }

        public string Pop()
        {
            var lastIndex = Urls.Count - 1;
            var lastUrl = Urls[lastIndex];
            return lastUrl;
        }

        public List<string> Urls { get; private set; }

        public BaseIterator CreateIterator()
        {
            return new ListIterator(this);
        }
    }

}
