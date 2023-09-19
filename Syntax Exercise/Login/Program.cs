using System;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";

            for (int i = username.Length - 1; i >= 0; i--) 
            {
                password += username[i];
            }

            int attepmts = 0;

            while (attepmts < 4)
            {
                string input = Console.ReadLine();
                attepmts++;

                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (attepmts == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;

                }
                else if (input != password)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}
