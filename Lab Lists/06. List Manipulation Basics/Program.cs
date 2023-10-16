using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] lineTokens = input.Split().ToArray();
                string command = lineTokens[0];

                if (command == "Add")
                {
                    int number = int.Parse(lineTokens[1]);
                    numbers.Add(number);
                }
                else if (command == "Remove")
                {
                    int number = int.Parse(lineTokens[1]);
                    numbers.Remove(number);
                }
                else if (command == "RemoveAt")
                {
                    int number = int.Parse(lineTokens[1]);
                    numbers.RemoveAt(number);
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(lineTokens[1]);
                    int index = int.Parse(lineTokens[2]);
                    numbers.Insert(index, number);

                }

                input = Console.ReadLine();

                
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
