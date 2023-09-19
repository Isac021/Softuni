using System;
using System.Diagnostics;

namespace _3Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string weekday = Console.ReadLine();
            double priceperson = 0;
            double final = 0;

            if (type == "Students" && weekday == "Friday")
            {
                priceperson = 8.45;
            }
            else if (type == "Students" && weekday == "Saturday")
            {
                priceperson = 9.80;
            }
            else if (type == "Students" && weekday == "Sunday")
            {
                priceperson = 10.46;
            }
            else if (type == "Business" && weekday == "Friday")
            {
                priceperson = 10.90;
            }
            else if (type == "Business" && weekday == "Saturday")
            {
                priceperson = 15.60;
            }
            else if (type == "Business" && weekday == "Sunday")
            {
                priceperson = 16;
            }
            else if (type == "Regular" && weekday == "Friday")
            {
                priceperson = 15;
            }
            else if (type == "Regular" && weekday == "Saturday")
            {
                priceperson = 20;
            }
            else if (type == "Regular" && weekday == "Sunday")
            {
                priceperson = 22.50;
            }
            final = priceperson * people;
            if (type == "Students" && people >= 30)
            {
                final = final * 0.85;
            }
            else if (type == "Business" && people >= 100)
            {
                final = final - (priceperson * 10);
            }
            else if (type == "Regular" && people >= 10 && people <= 20)
            {
                final = final * 0.95;
            }
            Console.WriteLine($"Total price: {final:f2}");





        }
    }
}
