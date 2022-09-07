using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class RealEBook : IEBook
    {
        private string fileName;
        public RealEBook(string fileName)
        {
            this.fileName = fileName;
            Load();
        }
        public void Load()
        {
            Console.WriteLine("Loading RealEBook {0} ...", fileName);
        }

        public void Show()
        {
            Console.WriteLine("Showing RealEBook {0} ...", fileName);
        }

        public string GetFileName()
        {
            return fileName;
        }
    }
}
