using System;

namespace _11._Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string operatorInput = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());
            double result = Calculate(firstNumber, operatorInput, secondNumber);
            Console.WriteLine(result);

        }

         static int Calculate(double firstNumber, string operatorInput, double secondNumber)
        {
            double result = 0;
            switch (operatorInput)
            {
                case "/":
                    result = firstNumber / secondNumber; break;
                case "*":
                    result = firstNumber * secondNumber; break;
                case "+":
                    result = firstNumber + secondNumber; break;
                case "-":
                    result = firstNumber - secondNumber; break;
            }

            return (int)result;


        }
    }
}
