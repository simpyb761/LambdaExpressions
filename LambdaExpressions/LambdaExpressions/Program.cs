using System;
using static System.Console;

namespace lamdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne =0;
            bool validCheck = false;
            while (!validCheck)
            {
                Console.WriteLine("Please enter a double value: ");
                validCheck = double.TryParse(Console.ReadLine(), out numberOne);
            }
            double numberTwo =0;
            bool validCheckTwo = false;
            while (!validCheckTwo)
            {
                Console.WriteLine("Please enter a second double value: ");
                validCheckTwo = double.TryParse(Console.ReadLine(), out numberTwo);
            }
            var multiple = (double a, double b) => {double result = a*b; return result; };
            var addition = (double a, double b) => { double result = a + b; return result; };
            var compare = (double a, double b) => { if (a < b) return a; else return b; } ;
            WriteLine($"{numberOne} x {numberTwo} = {multiple(numberOne, numberTwo)}");
            WriteLine($"{numberOne} + {numberTwo} = {addition(numberOne, numberTwo)}");
            WriteLine($"{compare(numberOne,numberTwo)} is the smaller number");
        }
    }
}