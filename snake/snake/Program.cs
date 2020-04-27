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
            Console.SetBufferSize(80, 25);

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


            
            Horizont horizont1 = new Horizont(1, 79, 1, chList[12]);
            Vertical vertical1 = new Vertical(78, 1, 24, chList[12]);
            Horizont horizont2 = new Horizont(1, 79, 24, chList[12]);
            Vertical vertical2 = new Vertical(1, 1, 24, chList[12]);


            horizont1.DrawPoint();
            vertical1.DrawPoint();
            horizont2.DrawPoint();
            vertical2.DrawPoint();

            Console.ReadLine();
        }
        
    }
}
