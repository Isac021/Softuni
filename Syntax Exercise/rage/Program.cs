using System;
using System.Runtime.Serialization.Formatters;

namespace rage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostgames = int.Parse(Console.ReadLine());
            double headsetprice = double.Parse(Console.ReadLine());
            int trashedheadset = 0;
            double mouseprice = double.Parse(Console.ReadLine());
            int trashedmouse = 0;
            double keyboardprice = double.Parse(Console.ReadLine());
            int trashedkeyboard = 0;
            double displayprice = double.Parse(Console.ReadLine());
            int displaycount = 0;
            int trasheddisplay = 0;

            double expenses = 0;


            for (int i = 1; i <= lostgames; i++)
            {
                if (i % 2 == 0)
                {
                    trashedheadset++;
                }
                if (i % 3 == 0)
                {
                    trashedmouse++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    trashedkeyboard++;
                    if (trashedkeyboard % 2 == 0)
                    {
                        displaycount = 1;
                    }
                }
                if (trashedkeyboard % 2 == 0 && displaycount == 1)
                {
                    trasheddisplay++;
                    displaycount = 0;

                }
            }

            expenses = (trashedheadset * headsetprice) + (trashedmouse * mouseprice) + (trashedkeyboard * keyboardprice) + (trasheddisplay * displayprice);
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
