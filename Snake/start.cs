﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class Start
    {
        public ConsoleKeyInfo key;
        public start()
        {

        }
        int valik = 0;
        public int choice()
        {
            Console.WriteLine("Start game - S\n Stop game - Q");
            key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.S)
            {
                valik = 1;
            }
            else if (key.Key == ConsoleKey.Q)
            {
                valik = 2;
            }
            return valik;
        }

        public void Game_stop()
        {
            Console.Clear();
            Console.WriteLine("Exit");
            Console.Beep();

        }
    }
}