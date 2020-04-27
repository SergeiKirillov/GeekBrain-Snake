using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class Vertical
    {
        List<Point> verPoint = new List<Point>();

        public Vertical(int x, int yStart, int yStop, char sym)
        {
            for (int i = yStart; i < yStop; i++)
            {
                Point Ypoint = new Point(x, i, sym);
                verPoint.Add(Ypoint);
            }
        }

        public void VerDraw()
        {
            foreach (Point item in verPoint)
            {
                item.Draw();
            }
        }
    }
}
