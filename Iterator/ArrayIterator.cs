namespace Iterator
{
    public class ArrayIterator : BaseIterator
    {
        private int index;
        public ArrayIterator(BrowseHistoryArray browseHistory)
        {
            History = browseHistory;
            index = 0;
        }

        public BrowseHistoryArray History { get; }

        public string Current()
        {
            return History.Urls[index];
        }

        public bool HasNext()
        {
            return (index < History.Urls.Length);
        }

        public void Next()
        {
            index++;
        }
    }
}
