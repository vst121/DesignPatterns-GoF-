using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var browseHistoryList = new BrowseHistoryList();
            browseHistoryList.Push("a");
            browseHistoryList.Push("b");
            browseHistoryList.Push("c");

            BaseIterator iterator = browseHistoryList.CreateIterator();

            while (iterator.HasNext())
            {
                var url = iterator.Current();
                Console.WriteLine(url);
                iterator.Next();
            }

            // ----- 

            var browseHistoryArray = new BrowseHistoryArray();
            browseHistoryArray.Push("x");
            browseHistoryArray.Push("y");
            browseHistoryArray.Push("z");

            iterator = browseHistoryArray.CreateIterator();

            while (iterator.HasNext())
            {
                var url = iterator.Current();
                Console.WriteLine(url);
                iterator.Next();
            }

            Console.ReadLine();
        }
    }
}
