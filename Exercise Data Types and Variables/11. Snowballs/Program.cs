using System;

namespace _11._Snowballs
{
    using System;

    class Snowballs
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double maxSnowballValue = 0;
            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            int bestSnowballQuality = 0;
             
            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                double snowballValue = Math.Pow((snowballSnow * 1.0 / snowballTime), snowballQuality);

                if (snowballValue > maxSnowballValue)
                {
                    maxSnowballValue = snowballValue;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {maxSnowballValue:f0} ({bestSnowballQuality})");
        }
    }
}
