using System;

namespace _6._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for(int k = 0; k < n; k++)
                    {
                        char firstchar = (char)('a' + i);
                        char secondchar = (char)('a' + j);
                        char thirdchar = (char)('a' + k);
                        Console.WriteLine($"{firstchar}{secondchar}{thirdchar}");
                    }
                }

            }
        }
    }
}
