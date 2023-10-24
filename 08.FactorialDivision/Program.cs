namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double factorialFirstNumber = 1;
            factorialFirstNumber = FactorialDivision(firstNumber, factorialFirstNumber);
            double factorialSecondNumber = 1;
            factorialSecondNumber = FactorialDivision(secondNumber, factorialSecondNumber);

            double sumOfTheNumbers = factorialFirstNumber / factorialSecondNumber;
            System.Console.WriteLine($"{sumOfTheNumbers:f2}");


        }

        static double FactorialDivision(int Number, double factorialNumber)
        {
            if (Number == 0)
            {
                Number = 1;
            }
            else
            {
                for (int i = Number; i > 0; i--)
                {
                    factorialNumber *= i;
                }
            }


            return factorialNumber;
        }
    }
}
