using System;
using System.Collections.Generic;
using MathsCalculations;


namespace ElementaryMathsProblems
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Calculation calculation = new();

            bool active = true;

            while (active)
            {
                List<string> list = new()
                {
                    "Program 1: Calculate the sum from 1 to the given number.",
                    "Program 2: Calculate the sum of the multiples of 3 and 5 from 1 to the given number.",
                    "Program 3: Choose whether to caluculate the sum or the factorial of a given number.",
                    "Program 4: Print out a multiplication table up to 12 of the given number.",
                    "Press number 5 to exit program."
                };
                list.ForEach(Console.WriteLine);

                Console.WriteLine("Enter a program number");
                string program = Console.ReadLine() ?? string.Empty;

                switch (program)
                {
                    case "1":
                        string sumN = Calculation.SumToNumber();
                        Console.WriteLine(sumN);
                        break;

                    case "2":
                        string multisumN = calculation.MultiSumToNumber();
                        Console.WriteLine(multisumN);
                        break;

                    case "3":
                        Console.WriteLine("Please choose 1 for the sum or 2 for the factorial.");
                        int c = Convert.ToInt32(Console.ReadLine());
                        if (c == 1)
                        {
                            string sumNAgain = Calculation.SumToNumber();
                            Console.WriteLine(sumNAgain);
                        }

                        else if (c == 2)
                        {
                            string factorialN = calculation.FactorialToNumber();
                            Console.WriteLine(factorialN);
                        }

                        else
                        {
                            Console.WriteLine("Sorry this is not a correct option!");
                        }
                        break;

                    case "4":
                        calculation.MultiplicationToNumber();

                        break;

                    case "5":
                        active = false;
                        break;


                    default:
                        Console.WriteLine("Not a prorgram");
                        break;
                }
            }
        }
    }
}