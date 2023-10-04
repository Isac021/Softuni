using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace _6._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sumodd = 0;
            int sumeven = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentnumber = numbers[i];
                if (currentnumber % 2 == 0)
                {
                    sumeven += currentnumber;
                }
                else
                {
                    sumodd += currentnumber;
                }
            }
            if (sumeven == 0)
            {
                int result = 0 - sumodd;
                Console.WriteLine(result);
            }
            else
            {
                int result = sumeven - sumodd;
                Console.WriteLine(result);
            }
            

            
        }
    }
}
