﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class EditorState
    {
        //private string content;

        public EditorState(string content)
        {
            this.Content = content;
        }

        public string Content { get; private set; }
    }
}
