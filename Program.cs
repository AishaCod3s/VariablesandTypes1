using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int result = 0;

            Console.Write("Please enter your first number; ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Please enter your second number; ");
            secondNumber = int.Parse(Console.ReadLine());

            result = firstNumber / secondNumber;
            Console.WriteLine("The answer is; " + result);

        }
    }
}
