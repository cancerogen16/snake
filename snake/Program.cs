using System;
using System.Collections.Generic;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            List<string> sList = new List<string>();
            sList.Add("*");
            sList.Add("#");
            sList.Add("+");

            foreach(string s in sList)
            {
                Console.WriteLine(s);
            }

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            foreach (Point p in pList)
            {
                Console.WriteLine(p);
            }

            Console.ReadLine();
        }
    }
}
