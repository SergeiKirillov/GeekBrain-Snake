using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point();
            point1.x = 1;
            point1.y = 2;
            point1.sym = '*';
            point1.Draw();


            Point point2 = new Point();
            point2.x = 3;
            point2.y = 4;
            point2.sym = '#';
            point2.Draw();

            Console.ReadLine();
        }
        
    }
}
