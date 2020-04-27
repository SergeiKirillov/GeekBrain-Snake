using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class figure
    {
        protected List<Point> point = new List<Point>();


        public void DrawPoint()
        {
            foreach (Point item in point)
            {
                item.Draw();
            }
        }
    }
}
