using System;

namespace _5._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            int price = int.Parse(Console.ReadLine());

            FinalOrder(order, price);


            static void FinalOrder(string order, int price)
            {
                double result = 0;

                switch (order)
                {
                    case "coffee":
                        result = price * 1.50;
                        break;
                    case "water":
                        result = price * 1.00;
                        break;
                    case "coke":
                        result = price * 1.40;
                        break;
                    case "snacks":
                        result = price * 2.00;
                        break;
                }
                Console.WriteLine($"{result:f2}");
            }

        }
    }
}
