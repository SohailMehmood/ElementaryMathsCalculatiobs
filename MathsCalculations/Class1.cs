namespace MathsCalculations
{
    public class Sum
    {

        public string SumToN()
        {
            int i, n, sum = 0;
            Console.WriteLine("Enter the value of n :");

            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                sum += i;
            }

            return "Total sum: " + sum;
        }
    }

    public class MultiSum
    {

        public string MultiSumToN()
        {
            int i, n, a, b, multisum = 0;
            Console.WriteLine("Enter the value of n :");

            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                a = i % 3;
                b = i % 5;
                if (a == 0 || b == 0)
                {
                    multisum += i;
                }

            }

            return "Total sum: " + multisum;
        }
    }

    public class Factorial
    {
        public string FactorialToN()
        {
            int i, f = 1, n;
            Console.WriteLine("Enter the value of n :");

            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                f = f * i;
            }

            return "The Factorial is: " + f;

        }
    }

    public class Multiplication
    {
        public void MultiplicationToN()
        {
            int i, f = 1, n;
            Console.WriteLine("Enter number to print table: ");

            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= 12; i++)
            {
                f = n * i;
                Console.WriteLine("{0} X {1} = {2}", n, i, f);
            }
        }

    }
}