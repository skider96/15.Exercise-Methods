namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*A top number is an integer that holds the following properties:
    • Its sum of digits is divisible by 8, e.g. 8, 17, 88
    • Holds at least one odd digit, e.g. 232, 707, 87578
    • Some examples of top numbers are: 17, 161, 251, 4310, 123200 
    Create a program to print all top numbers in the range [1…n].
    You will receive a single integer from the console, representing the end value.*/
            int n = int.Parse(Console.ReadLine());
            List<int> digit = new List<int>();
            for (int i = 1; i <= n; i++)
            {

                while (n == 0)
                {
                    digit.Add(n % 10);
                }
                if (digit.Sum() % 8 == 0)
                {
                    System.Console.WriteLine(i);
                }
                if (digit.Where(i => i % 2 == 0))
                {
                    
                }
// i => i % 2 == 0

                // if (IsTopNumber(i))
                // {
                //     Console.WriteLine(i);
                // }
            }

        }
    }
}

