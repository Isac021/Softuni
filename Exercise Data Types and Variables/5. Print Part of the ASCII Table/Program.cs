using System;
using System.Runtime.InteropServices;

namespace _5._Print_Part_of_the_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstn = int.Parse(Console.ReadLine());
            int secondn = int.Parse(Console.ReadLine());

            for (int i = firstn; i <= secondn; i++)
            {
                string asciichar = ((char)i).ToString();
                Console.Write(asciichar + " ");
            }
        }
    }
}
