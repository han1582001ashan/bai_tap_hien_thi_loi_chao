﻿using System;
namespace DisplayHello
{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter your name: ");
            string yourName = Console.ReadLine();
            Console.WriteLine("Hello " + yourName); 
        }
    }
}

