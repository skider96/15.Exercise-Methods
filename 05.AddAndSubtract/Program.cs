namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            for (int i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Substraction(numbers);

            Console.WriteLine(Substraction(numbers));
        }

        private static int Substraction(int[] numbers)
        {
            int final = SumOfFirstNumbers(numbers) - numbers[2];
            return final;
        }

        static int SumOfFirstNumbers(int[] numbers)
        {
             int sum = numbers[0] + numbers[1];
             return sum;
        }
    }
}
