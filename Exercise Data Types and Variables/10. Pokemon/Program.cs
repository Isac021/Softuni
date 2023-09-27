using System;

namespace _10._Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int factor = int.Parse(Console.ReadLine());
            int counter = 0;
            double percent = power / 2;

            while (power >= distance)
            {
                counter++;
                power -= distance;
                if (power == percent && factor != 0)
                {
                    power /= factor;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(counter);
        }
    }
}
