using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Box> boxes = new List<Box>();
            while (input != "end")
            {
                string[] tokens = input.Split(' ');

                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                decimal itemPrice = decimal.Parse(tokens[3]);

                Box box = new Box();

                box.SerialNumber = serialNumber;
                box.Item = itemName;
                box.ItemQuantity = itemQuantity;
                box.PriceForABox = itemPrice;
                box.TotalPrice = itemQuantity * itemPrice;
                boxes.Add(box);

                
                input = Console.ReadLine();
            }
            List<Box> sortedBox = boxes.OrderByDescending(boxes => boxes.TotalPrice).ToList();


            foreach (Box box in sortedBox)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item} - ${box.PriceForABox:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.TotalPrice:f2}");
            }
        }
    }

    

    public class Box
    {
        
        public string SerialNumber { get; set; }
        public string Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForABox { get; set; }
        public decimal TotalPrice { get; set; }
        
        
    }


}
