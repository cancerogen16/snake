﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            HorizontalLine topLine = new HorizontalLine(0, 78, 0, '-');
            HorizontalLine bottomLine = new HorizontalLine(0, 78, 24, '-');

            VerticalLine leftLine = new VerticalLine(0, 24, 0, '|');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '|');

            topLine.Draw();
            bottomLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p = new Point(2, 3, '*');

            Snake snake = new Snake(p, 5, Direction.RIGHT);

            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();

                    snake.HandleKey(key.Key);
                }

                Thread.Sleep(100);
                snake.Move();
            }

            Console.ReadLine();
        }
    }
}
