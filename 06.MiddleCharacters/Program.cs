namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You will receive a single string.Create a method that prints the character found at its middle. If the length of the
            //string is even, there are two middle characters.

            string input = Console.ReadLine();
            var firstChar = FirstChar(input);

            char secondChar = '\0';
            if (input.Length % 2 == 0) 
            {
                secondChar = SecondChar(input);
                Console.WriteLine($"{firstChar}{secondChar}");
                return;
            }
            else
            {
                Console.WriteLine(firstChar);
            }
        }

        static char SecondChar(string input)
        {
            char secondChar;
            secondChar = input[input.Length / 2];
            return secondChar;
        }

        private static char FirstChar(string? input)
        {
            char firstChar = '\0';
            for (var i = 1; i <= (input.Length - 1) / 2; i++)
            {
                firstChar = input[i];
            }

            return firstChar;
        }
    }
}
