using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class EBookProxy : IEBook
    {
        private string fileName;
        private RealEBook realEBook;

        public EBookProxy(string fileName)
        {
            this.fileName = fileName;
        }

        public void Show()
        {
            if (realEBook == null)
                realEBook = new RealEBook(fileName);

            realEBook.Show();
        }
        public string GetFileName()
        {
            return fileName;
        }
    }
}
