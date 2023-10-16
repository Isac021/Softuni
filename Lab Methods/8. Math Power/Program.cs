using System;

namespace _8._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = RaiseToPower(number, power);
            Console.WriteLine(result);

            static double RaiseToPower(double number, int power)
            {
                if (power == 0)
                {
                    return 0;
                }

                return Math.Pow(number, power);
            }
        }
    }
}
