﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 120);   //original 80 , 25

            //draw square
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+'); 
            upLine.Draw();
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            downLine.Draw();
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            leftLine.Draw();
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            rightLine.Draw();

            //Create snake
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.Right);
            snake.Draw();

            while(true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.MoveSnake();
            }                   
        }        
    }
}
