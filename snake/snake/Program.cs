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
            List<char> chList = new List<char>();
            chList.Add('~');
            chList.Add('!');
            chList.Add('@');
            chList.Add('#');
            chList.Add('$');
            chList.Add('%');
            chList.Add('^');
            chList.Add('&');
            chList.Add('*');
            chList.Add('(');
            chList.Add(')');
            chList.Add('_');
            chList.Add('+');


            //List<Point> point = new List<Point>();
            //point.Add(new Point(1, 2, chList[1]));
            //point.Add(new Point(3, 4, chList[2]));
            //point.Add(new Point(5, 6, chList[3]));
            //point.Add(new Point(7, 8, chList[4]));

            //foreach (Point i in point)
            //{
            //    i.Draw();
            //}

            Horizont horizont = new Horizont(1, 40, 5, chList[8]);
            horizont.HorDraw();

            Vertical vertical = new Vertical(39, 6, 20, chList[8]);
            vertical.VerDraw();


            Console.ReadLine();
        }
        
    }
}
