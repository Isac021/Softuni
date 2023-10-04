using System;
using System.Linq;

namespace _4._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < text.Length / 2; i++)
            {
                string firstelement = text[i];
                string lastelement = text[text.Length - 1 - i];

                text[i] = lastelement;
                text[text.Length - 1 - i] = firstelement;
            }
            Console.WriteLine(string.Join(" ", text));
        }
    }
}
