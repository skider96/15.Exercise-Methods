using System.ComponentModel.DataAnnotations;

namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            forCycleTo3(numbers);

            System.Console.WriteLine(numbers.Min());

        }

        private static void forCycleTo3(int[] numbers)
        {
            for (var i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
