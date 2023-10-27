using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> randomText = Console.ReadLine().Split(' ').ToList();

            Random random = new Random();

            for (int i = 0; i < randomText.Count; i++)
            {
                int index = random.Next(randomText.Count);

                string currentNumber = randomText[i];
                string randomNumber = randomText[index];

                randomText[i] = randomNumber;
                randomText[index] = currentNumber;
            }

            foreach (string word in  randomText)
            {
                Console.WriteLine(word);
            }
        }
    }
}
