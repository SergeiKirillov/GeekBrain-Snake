using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class snake:figure
    {
        public snake(Point tall, int lenght, Direction direction)
        {
             point = new List<Point>();

            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tall);
                p.Move(i, direction);
                point.Add(p);
            }
        }
    }
}
