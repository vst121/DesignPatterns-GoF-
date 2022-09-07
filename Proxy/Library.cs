using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Library
    {
        private Dictionary<string, IEBook> eBooks = new Dictionary<string, IEBook>(); 
        internal void AddEBook(IEBook eBook)
        {
            eBooks.Add(eBook.GetFileName(), eBook);
        }

        public void OpenEBook(string fileName)
        {
            eBooks[fileName].Show();
        }
    }
}
