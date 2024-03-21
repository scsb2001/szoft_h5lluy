using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6
{
    internal class SnakeElem : PictureBox
    {
        public static int Size = 20;

        public SnakeElem()
        {
            this.Width = SnakeElem.Size;
            this.Height = SnakeElem.Size;
            this.BackColor = Color.Fuchsia;
        }

        public SnakeElem(int x, int y)
        {
            this.Width = SnakeElem.Size;
            this.Height = SnakeElem.Size;
            this.BackColor = Color.Fuchsia;
            this.Top = y;
            this.Left = x;
        }
    }
}
