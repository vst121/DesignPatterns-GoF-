using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Canvas
    {
        public void MosueDown()
        {
            CurrentTool.MosueDown();
        }

        public void MosueUp()
        {
            CurrentTool.MosueUp();
        }
        public ITool CurrentTool { get; set; }
    }
}
