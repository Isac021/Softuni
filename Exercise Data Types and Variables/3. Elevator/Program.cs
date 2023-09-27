using System;

namespace _3._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberpeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)numberpeople / capacity);

            Console.WriteLine(courses);
        }
    }
}
