using System;
using System.Linq;

namespace _7._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum1 = 0;
            

            for (int i = 0; i < arr1.Length; i++)
            {
                int currentnumber1 = arr1[i];
                int currentnumber2 = arr2[i];
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }

                sum1 += currentnumber1;
                
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum1}");


        }
    }
}
