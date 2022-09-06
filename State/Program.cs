using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Canvas canvas = new Canvas();

            canvas.CurrentTool = new SelectionTool();
            canvas.MosueDown();
            canvas.MosueUp();

            canvas.CurrentTool = new BrushTool();
            canvas.MosueDown();
            canvas.MosueUp();

            Console.ReadLine();
        }
    }
}
