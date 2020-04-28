using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class FoodCreator
    {
        int mapWidth;
        int mapHeight;
        char sym;

        Random ramDom = new Random();

        public FoodCreator(int _mapWidth, int _mapHeight, char sym)
        {
            mapWidth = _mapWidth;
            mapHeight = _mapHeight;
            this.sym = sym;
        }

        public Point CreatePoint()
        {
            int x = ramDom.Next(2,mapWidth-2);
            int y = ramDom.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}
