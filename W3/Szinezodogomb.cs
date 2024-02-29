using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3
{
    internal class SzinezodoGomb : Button
    {

        public SzinezodoGomb()
        {
            this.Height = 20;
            this.Width = 20;
            MouseClick += SzinezodoGomb_MouseClick;
        }

        private void SzinezodoGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            this.BackColor = Color.Fuchsia;
        }
    }
}
