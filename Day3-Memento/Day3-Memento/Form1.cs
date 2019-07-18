using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day3_Memento
{
    public partial class Form1 : Form
    {
        private readonly TextContext ctx = new TextContext();
        public Form1()
        {
            InitializeComponent();
        }

        

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ctx.Save(rText);
        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {
            ctx.LoadUndo(rText);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void rText_TextChanged(object sender, EventArgs e)
        {
        }
        
        private void RedoBtn_Click(object sender, EventArgs e)
        {
            ctx.LoadRedo(rText);
        }
    }
}
