﻿using System;
using PL;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            menu.Start();
            Console.ReadLine();
        }
    }
}
