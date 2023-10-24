//using System;

//namespace _04.PasswordValidator
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string input = Console.ReadLine();

//            if (!(input.Length <= 10 && input.Length >= 6))
//            {
//                Console.WriteLine("Password must be between 6 and 10 characters");
//            }
//            List<char> charsFromInput = new List<char>();
//            char[] charArray = input.ToCharArray();
//            int isTrue = 0;
//            for (int i = 0; i < charArray.Length - 1; i++)
//            {
//                charsFromInput.Add(charArray[i]);
//                if (charsFromInput[i] >= 65 && charsFromInput[i] <= 90 && charsFromInput[i] >= 97 && charsFromInput[i] <= 122
//                    && charsFromInput[i] >= 48 && charsFromInput[i] <= 57)
//                {
//                    isTrue++;
//                }
//            }

//            if (isTrue >= 2)
//            {
//                Console.WriteLine("Password must consist only of letters and digits");
//            }

//            int counter = 0;
//            for (var i = 0; i < charsFromInput.Count; i++)
//            {
//                if (charsFromInput[i] >= 48 && charsFromInput[i] <= 57)
//                {
//                    counter++;
//                    if (counter >= 2)
//                    {
//                        Console.WriteLine("Password is valid");
//                        break;
//                    }
//                }
//            }
//            if (counter == 0) Console.WriteLine("Password must have at least 2 digits");
//        }
//    }
//}

using System;
using System.Linq;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isLengthValid = password.Length >= 6 && password.Length <= 10;
            bool isAlphanumeric = password.All(char.IsLetterOrDigit);
            bool hasTwoDigits = password.Count(char.IsDigit) >= 2;

            
            if (isLengthValid && isAlphanumeric && hasTwoDigits)
            {
                Console.WriteLine("Password is valid.");
            }
            else
            {
                if (!isLengthValid)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters.");
                }

                if (!isAlphanumeric)
                {
                    Console.WriteLine("Password must consist only of letters and digits.");
                }

                if (!hasTwoDigits)
                {
                    Console.WriteLine("Password must have at least 2 digits.");
                }
            }
        }
    }
}
