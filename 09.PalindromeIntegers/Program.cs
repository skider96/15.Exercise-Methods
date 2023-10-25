namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            List<int> number = new List<int>();

            int n = 0;
            int reversedNumber = 0;
            int digit = 1;

            while ((command = Console.ReadLine()) != "END")
            {
                number.Add(int.Parse(command));
                bool isPalindrome = false;
                int copyNumber = number[n];

                while (number[n] != 0)
                {
                    digit = number[n] % 10;
                    reversedNumber = reversedNumber * 10 + digit;
                    number[n] = number[n] / 10;

                }
                if (reversedNumber == copyNumber)
                {
                    isPalindrome = true;
                }
                reversedNumber = 0;
                System.Console.WriteLine(isPalindrome);
                n++;
            }
        }
    }
}
// int digit = number % 10; // Взимаме последната цифра на числото
//             reversedNumber = reversedNumber * 10 + digit; // Обръщаме числото наобратно
//             number = number / 10; // Премахваме последната цифра от числото