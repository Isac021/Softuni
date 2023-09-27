using System;

namespace _8._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  n = int.Parse(Console.ReadLine());
            double bigeestkeg = 0;
            string kegname = "";
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * (radius * radius) * height;
                if (volume > bigeestkeg)
                {
                    bigeestkeg = volume;
                    kegname = model;
                }
            }
            Console.WriteLine(kegname);

        }
    }
}
