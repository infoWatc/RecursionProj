/*
    The following is a demonstration of the ternary conditonal 
    operatior in recursive functions.
        condition ? consequent : alternative
*/
using System;

namespace RecursiveFunctions
{
    class Program
    {
        //Factorial Method
        public static int Factorial(int num)
        {
            //if (num == 0) return 1;
            //return num * Factorial(num - 1);

            return (num > 0) ? num * Factorial(num - 1) : 1;
        }

        // Fibonacci Method
        static long FIbonacci(long num)
        {
            return (num > 1) ? FIbonacci(num - 2) + FIbonacci(num - 1) : num;
        }

        // Division Method
        static dynamic Divide(double num, double num2)
        {
            return (num > 0) ? num / num2 : 0;
        }

        // Main
        static void Main(string[] args)
        {
            // Declare Variables
            int factNum2Display = 12;
            long fibNum = 10;

            // Send to Method and Print to Console
            Console.WriteLine($"The Factorial of {factNum2Display} is: {Factorial(factNum2Display)}");            
            Console.WriteLine($"The Fibonacci number of {fibNum} is: {FIbonacci(fibNum)}");
            Console.WriteLine($"The division of 15 & 3 is: {Divide(16.6, 4)}");
        }

    }
}
