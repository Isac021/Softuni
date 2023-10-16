using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ExceptionServices;

namespace _2._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            List<int> result = new List<int>();
 
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int firstNumber = numbers[i];
                int lastNumber = numbers[numbers.Count - i - 1];
                result.Add(firstNumber + lastNumber);

                
            }
            if (numbers.Count % 2 == 1)
            {
                int middle = numbers.Count / 2;
                result.Add(numbers[middle]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
