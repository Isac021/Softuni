using System;

namespace padawan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double pricepersaber = double.Parse(Console.ReadLine());
            double priceperrobe = double.Parse(Console.ReadLine());
            double priceperbelt = double.Parse(Console.ReadLine());
            double totalprice = 0;

            
            double pricerobes = students * priceperrobe;
            
            double students1 = Math.Ceiling((students * 0.1) + students);
            double belt = students / 6;

             totalprice = pricerobes + (pricepersaber * students1) + ((students - belt) * priceperbelt);


            if (totalprice > money)
            {
                
                Console.WriteLine($" John will need {totalprice - money:f2}lv more.");
            }
            else if (totalprice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalprice:f2}lv.");
            }
        }
    }
}
