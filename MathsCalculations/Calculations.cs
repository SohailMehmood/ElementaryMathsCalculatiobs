namespace MathsCalculations
{
    public class Calculation
    {

        public static string SumToNumber()
        {
            Console.WriteLine("Enter a value to calculate the sum: ");

            int enteredValue = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= enteredValue; i++)
            {
                sum += i;
            }

            return "Total sum: " + sum;
        }

        public string MultiSumToNumber()
        {
            Console.WriteLine("Enter the value of n :");

            int secondEnteredValue = Convert.ToInt32(Console.ReadLine());

            int multisum = 0;
            for (int i = 1; i <= secondEnteredValue; i++)
            {
                int a = i % 3;
                int b = i % 5;
                if (a == 0 || b == 0)
                {
                    multisum += i;
                }

            }

            return "Total sum: " + multisum;
        }

        public string FactorialToNumber()
        {
            
            Console.WriteLine("Enter the value of n :");

            int thirdEnteredValue = Convert.ToInt32(Console.ReadLine());
            
            int factorial = 1;
            for (int i = 1; i <= thirdEnteredValue; i++)
            {
                factorial = factorial * i;
            }

            return "The Factorial is: " + factorial;

        }

        public void MultiplicationToNumber()
        {
            
            Console.WriteLine("Enter number to print table: ");

            int fourthEnteredValue = Convert.ToInt32(Console.ReadLine());
            
            int multiplicationTable = 1;
            for (int i = 1; i <= 12; i++)
            {
                multiplicationTable = fourthEnteredValue * i;
                Console.WriteLine("{0} X {1} = {2}", fourthEnteredValue, i, multiplicationTable);
            }
        }

    }
}