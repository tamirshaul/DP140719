using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Memento
{
    public class TextMemento
    {
        public readonly string savedText;

        public TextMemento(string savedText)
        {
            this.savedText = savedText;
        }
    }
}
