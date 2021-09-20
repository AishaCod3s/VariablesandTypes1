using System.Reflection.Metadata;
using System.Collections.Concurrent;
using System.Reflection.Emit;
using System.Data;
using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;
            int result = 0;

            Console.Write("Please enter your first number; ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Please enter your second number; ");
            secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Please enter your third number; ");
            thirdNumber = int.Parse(Console.ReadLine());

            result = firstNumber * secondNumber * thirdNumber;
            Console.WriteLine("The answer is; " + result);
        }
    }
}
