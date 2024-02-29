using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3
{
    internal class SzamoloGomb : VillogoGomb
    {
        int szam = 0;

        public SzamoloGomb(int size)
        {
            this.Height = size;
            this.Width = size;
            MouseClick += SzamoloGomb_MouseClick;
        }

        private void SzamoloGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            this.szam = ++(this.szam) % 6;
            this.Text = szam.ToString();
        }
    }
}
