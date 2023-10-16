using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string input = Console.ReadLine();
            bool changes = false;

            while (input != "end")
            {
                string[] lineTokens = input.Split();
                
                if (lineTokens[0] == "end")
                {
                    break;
                }
                else if (lineTokens[0] == "Add")
                {
                    int number = int.Parse(lineTokens[1]);
                    numbers.Add(number);
                    changes = true;
                    
                }
                else if (lineTokens[0] == "Remove")
                {
                    int number = int.Parse(lineTokens[1]);
                    numbers.Remove(number);
                    changes = true;
                    
                }
                else if (lineTokens[0] == "RemoveAt")
                {
                    int number = int.Parse(lineTokens[1]);
                    numbers.RemoveAt(number);
                    changes = true;
                    
                }
                else if (lineTokens[0] == "Insert")
                {
                    int number = int.Parse(lineTokens[1]);
                    int index = int.Parse(lineTokens[2]);
                    numbers.Insert(index, number);
                    changes = true;
                    

                }

                else if (lineTokens[0] == "Contains")
                {
                    int number = int.Parse(lineTokens[1]);
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");


                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                    
                }
                else if (lineTokens[0] == "PrintEven")
                {
                    List<int> even = new List<int>();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            even.Add(numbers[i]);
                        }

                    }
                    Console.WriteLine(string.Join(" ", even));
                   
                }
                else if (lineTokens[0] == "PrintOdd")
                {
                    List<int> odd = new List<int>();
                    for (int i = 0;i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            odd.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", odd));
                    
                }
                else if (lineTokens[0] == "GetSum")
                {
                    int sum = numbers.Sum();
                    Console.WriteLine(sum);
                    
                }
                else if (lineTokens[0] == "Filter")
                {
                    string condition = (lineTokens[1]);
                    int number = int.Parse(lineTokens[2]);
                    
                    if (condition == "<")
                    {
                        List<int> conditionNumbers = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < number)
                            {
                                conditionNumbers.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", conditionNumbers));
                    }
                    else if (condition == ">")
                    {
                        List<int> conditionNumbers = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > number)
                            {
                                conditionNumbers.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", conditionNumbers));
                    }
                    else if (condition == ">=")
                    {
                        List<int> conditionNumbers = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] >= number)
                            {
                                conditionNumbers.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", conditionNumbers));
                    }
                    else if (condition == "<=")
                    {
                        List<int> conditionNumbers = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] <= number)
                            {
                                conditionNumbers.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", conditionNumbers));
                    }
                    
                    
                    
                }
                input = Console.ReadLine();


            }
            if (changes == true)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            

        }
    }
}
