﻿using System;

namespace _2._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double result = n * 1.31;

            Console.WriteLine($"{result:f3}");
        }
    }
}
