namespace Iterator
{
    public class ListIterator : IIterator
    {
        private int index;
        public ListIterator(BrowseHistoryList browseHistory)
        {
            History = browseHistory;
            index = 0;
        }

        public BrowseHistoryList History { get; }

        public string Current()
        {
            return History.Urls[index];
        }

        public bool HasNext()
        {
            return (index < History.Urls.Count);
        }

        public void Next()
        {
            index++;
        }
    }
}
