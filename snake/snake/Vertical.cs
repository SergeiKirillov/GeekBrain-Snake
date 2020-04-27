using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class Vertical:figure
    {
        public Vertical(int x, int yStart, int yStop, char sym)
        {
            for (int i = yStart; i < yStop; i++)
            {
                Point Ypoint = new Point(x, i, sym);
                point.Add(Ypoint);
            }
        }

    }
}
