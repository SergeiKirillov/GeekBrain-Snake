using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class Point
    {
        private int x;
        private int y;
        private char sym;

        public Point()
        {
        }

        public Point(int _x, int _y, char _sym)
        {
            this.x = _x;
            this.y = _y;
            this.sym = _sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
