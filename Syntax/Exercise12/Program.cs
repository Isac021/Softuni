using System;

namespace Exercise12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            
            while (number % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                number = int.Parse(Console.ReadLine());


                if (number % 2 == 0)
                {
                    break;
                }
            }

            Console.WriteLine($"The number is: {Math.Abs(number)}");
        }
    }
}
