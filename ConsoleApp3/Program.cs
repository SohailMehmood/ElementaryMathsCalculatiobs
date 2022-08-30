using System;
using MathsCalculations;


namespace ConsoleApp3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Sum sum = new Sum();
            MultiSum multisum = new MultiSum();
            Factorial factorial = new Factorial();
            Multiplication multiplication = new Multiplication();

            Console.WriteLine("Enter a program number");
            string program = Console.ReadLine() ?? string.Empty;

            switch (program)
            {
                case "1":
                    string sumN = sum.SumToN();
                    Console.WriteLine(sumN);
                    break;

                case "2":
                    string multisumN = multisum.MultiSumToN();
                    Console.WriteLine(multisumN);
                    break;

                case "3":
                    Console.WriteLine("Please choose 1 for the sum or 2 for the factorial.");
                    int c = Convert.ToInt32(Console.ReadLine());
                    if (c == 1)
                    {
                        string sumNAgain = sum.SumToN();
                        Console.WriteLine(sumNAgain);
                    }

                    else if (c == 2)
                    {
                        string factorialN = factorial.FactorialToN();
                        Console.WriteLine(factorialN);
                    }

                    else
                    {
                        Console.WriteLine("Sorry this is not a correct option!");
                    }
                    break;

                case "4":
                    multiplication.MultiplicationToN();

                    break;

                default:
                    Console.WriteLine("Not a prorgram");
                    break;
            }
        }
    }
}