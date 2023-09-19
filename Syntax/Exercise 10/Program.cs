using System;
using System.IO;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;

namespace Exercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int endresult = 0;

            for (int i = 1; i <= 10; i++)
            {
                endresult = number * i;
                Console.WriteLine($"{number} X {i} = {endresult}");
            }
            
        }
    }
}
