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

        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
            this.sym = p.sym;
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

        public void Move(int offset, Direction direct)
        {
            if (direct==Direction.RIGHT)
            {
                this.x += offset;

            }

            if (direct == Direction.LEFT)
            {
                this.x -= offset;

            }

            if (direct == Direction.UP)
            {
                this.y += offset;

            }
            if (direct == Direction.DOWN)
            {
                this.y -= offset;

            }
        }

        internal void Clear()
        {
            sym = ' ';
            Draw();
        }

        public override string ToString()
        {
            return x + "," + y + "," +sym;
        }
    }
}
