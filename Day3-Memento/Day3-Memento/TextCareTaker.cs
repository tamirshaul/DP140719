using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day3_Memento
{
    public class TextCareTaker
    {
        List<TextMemento> mementoList = new List<TextMemento>() { new TextMemento("") };
        int curr = 1;

        public void AddMemento(TextMemento memento)
        {
            if (curr <= 0)
            {
                curr = 1;
            }
            if(mementoList.Count == 0)
            {
                mementoList.Add(new TextMemento(""));
            }
            if (memento.savedText != mementoList[curr-1].savedText)
            {
                mementoList.RemoveRange(curr, mementoList.Count - curr);
                mementoList.Add(memento);
                curr++;
            }
        }

        public TextMemento GetUndoLast()
        {
            if(curr > 0)
            {
                return mementoList[--curr];
            }
            return new TextMemento("");
        }

        public TextMemento GetRedoLast(RichTextBox box)
        {
            if (mementoList.Count > 0 && curr < mementoList.Count - 1)
            {
                return mementoList[++curr];
            }
            return new TextMemento(box.Text);
        }
    }
}
