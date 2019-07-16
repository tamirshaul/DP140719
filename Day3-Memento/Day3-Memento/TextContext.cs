using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day3_Memento
{
    public class TextContext
    {
        TextCareTaker careTake = new TextCareTaker();

        public void Save(RichTextBox richTex)
        {
            careTake.AddMemento(new TextMemento(richTex.Text));
        }

        public void LoadUndo(RichTextBox richText)
        {
            var last = careTake.GetUndoLast();
            if (last != null && last.savedText != null)
                richText.Text = last.savedText;
        }

        public void LoadRedo(RichTextBox richText)
        {
            var last = careTake.GetRedoLast(richText);
            if (last != null && last.savedText != null)
                richText.Text = last.savedText;
        }

    }
}
