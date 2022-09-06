using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ImageStorage
    {
        public ImageStorage(ICompressor compresor, IFilter filter)
        {
            Compressor = compresor;
            Filter = filter;
        }

        public void Store(string fileName)
        {
            Compressor.Compress(fileName);
            Filter.ApplyFilter(fileName);
        }

        public ICompressor Compressor { get; private set; }
        public IFilter Filter { get; set; }
    }
}
