
using System;

namespace eXERCRISE_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= number; i++)
            {
                int currentnumber = i * 2 - 1;
                Console.WriteLine(currentnumber);
                sum += currentnumber;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
