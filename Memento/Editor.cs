using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Editor
    {
       // private string content;
        public EditorState CreateState()
        {
            return new EditorState(Content);
        }
        public void Restore(EditorState state)
        {
            Content = state.Content;
        }

        public string Content { get; set; }

    }
}
