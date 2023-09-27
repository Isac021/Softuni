using System;

namespace _9._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int days = 0;
            int produced = 0;

            if (n < 100)
            {
                Console.WriteLine(days);
                Console.WriteLine(produced);

            }
            else
            {

                while (n >= 100)
                {
                    produced += n - 26;
                    n -= 10;
                    days++;
                }
                produced -= 26;
                Console.WriteLine(days);
                Console.WriteLine(produced);


            }
        }
    }
}
