﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1,3,'*');
            point1.Draw();


            Point point2 = new Point(4,5,'#');
            point2.Draw();

            Console.ReadLine();
        }
        
    }
}
