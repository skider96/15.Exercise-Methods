namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            List<int> number = new List<int>();
bool isCycling = false;
            int n = 0;
            int reversedNumber = 0;
            int digit = 1;
            while ((command = Console.ReadLine()) != "end")
            {
                number.Add(int.Parse(command));

                while (isCycling)
                {
                    digit = number[n] % 10;
                    reversedNumber = reversedNumber * 10 + digit;
                    digit = number[n] / 10;
                    if (digit == 0)
                    {
                        isCycling = false;
                    }
                }


                n++;
            }
            System.Console.WriteLine(digit);
            System.Console.WriteLine(string.Join(" ", number));
        }
    }
}
// int digit = number % 10; // Взимаме последната цифра на числото
//             reversedNumber = reversedNumber * 10 + digit; // Обръщаме числото наобратно
//             number = number / 10; // Премахваме последната цифра от числото