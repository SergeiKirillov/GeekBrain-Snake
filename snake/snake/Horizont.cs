using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class Horizont:figure
    {
        

        public Horizont(int xStart, int xStop, int y, char sym)
        {
            for (int i = xStart; i < xStop; i++)
            {
                Point Xpoint = new Point(i, y, sym);
                point.Add(Xpoint);
            }
        }

    }
}
