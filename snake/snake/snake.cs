using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class snake:figure
    {
        Direction direction;

        public snake(Point tall, int lenght, Direction _direction)
        {
            direction = _direction;
             point = new List<Point>();

            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tall);
                p.Move(i, direction);
                point.Add(p);
            }
        }

        internal void Move()
        {
            Point tall = point.First();
            point.Remove(tall);
            Point head = getNextPoint();
            point.Add(head);

            tall.Clear();
            head.Draw();


            
        }

        private Point getNextPoint()
        {
            Point head = point.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandKey (ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow) direction = Direction.LEFT;
            if (key == ConsoleKey.RightArrow) direction = Direction.RIGHT;
            if (key == ConsoleKey.UpArrow)  direction = Direction.UP;
            if (key == ConsoleKey.DownArrow) direction = Direction.DOWN;
        }
    }
}
