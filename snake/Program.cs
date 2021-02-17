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

            HorizontalLine hLine = new HorizontalLine(4, 10, 5, '-');
            hLine.Draw();

            VerticalLine vLine = new VerticalLine(4, 10, 5, '|');
            vLine.Draw();

            Console.ReadLine();
        }
    }
}
