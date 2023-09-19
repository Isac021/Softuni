using System;

namespace coffee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double finalprice = 0;


            for (int i = 1; i <= n; i++)
            {
                double pricepercapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsules = int.Parse(Console.ReadLine());


                double price = ((days * capsules) * pricepercapsule);
                Console.WriteLine($"The price for the coffee is: ${price:f2}");

                finalprice += price;





            }
            Console.WriteLine($"Total: ${finalprice:f2}");
        }
    }
}
