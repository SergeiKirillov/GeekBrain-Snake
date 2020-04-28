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
            Console.SetBufferSize(120, 45);

            List<char> chList = new List<char>();
            chList.Add('~');    //0
            chList.Add('!');    //1
            chList.Add('@');    //2
            chList.Add('#');    //3
            chList.Add('$');    //4
            chList.Add('%');    //5
            chList.Add('^');    //6
            chList.Add('&');    //7
            chList.Add('*');    //8
            chList.Add('(');    //9
            chList.Add(')');    //10
            chList.Add('_');    //11
            chList.Add('+');    //12


            
            Horizont horizont1 = new Horizont(1, 79, 1, chList[12]);
            Vertical vertical1 = new Vertical(78, 1, 24, chList[12]);
            Horizont horizont2 = new Horizont(1, 79, 24, chList[12]);
            Vertical vertical2 = new Vertical(1, 1, 24, chList[12]);


            horizont1.DrawPoint();
            vertical1.DrawPoint();
            horizont2.DrawPoint();
            vertical2.DrawPoint();

            Point p = new Point(4, 5, chList[8]);
            snake SnakeMov = new snake(p, 4, Direction.UP);
            SnakeMov.DrawPoint();

            Console.ReadLine();
        }
        
    }
}
