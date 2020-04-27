using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class Horizont
    {
        List<Point> plist = new List<Point>();

        public Horizont(int xStart, int xStop, int y, char sym)
        {
            for (int i = xStart; i < xStop; i++)
            {
                Point point = new Point(i, y, sym);
                plist.Add(point);
            }
        }

        public void HorDraw()
        {
            foreach (Point item in plist)
            {
                item.Draw();
            }
        }
    }
}
