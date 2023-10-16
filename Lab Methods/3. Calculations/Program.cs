using System;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Xml.XPath;

namespace _3._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstn = int.Parse(Console.ReadLine());
            int secondn = int.Parse(Console.ReadLine());
            printNumbers(firstn, secondn, command);

            static void printNumbers(int  firstn, int secondn, string command)
            {
                int finalresult = 0;
                if (command == "add")
                {
                    finalresult = firstn + secondn;
                    Console.WriteLine(finalresult);
                }
                else if (command == "multiply")
                {
                    finalresult = firstn * secondn;
                    Console.WriteLine(finalresult);
                }
                else if (command == "subtract")
                {
                    finalresult = firstn - secondn;
                    Console.WriteLine(finalresult);
                }
                else if ( command == "divide")
                {
                    finalresult = firstn / secondn;
                    Console.WriteLine(finalresult);
                }
            }

            



        }
    }
}
