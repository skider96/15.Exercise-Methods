namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args, string? s)
        {
            List<char> symbols = new List<char>(2);

            List<char> symbolsFromAscii = new List<char>();

            for (var i = 0; i <= 2; i++)
            {
                char input = char.Parse(Console.ReadLine());
                symbols.Add(input);
            }
            if (symbols[0] > symbols[1])
            {
                symbols.Reverse();
            }

            for (var i = symbols[0] ;i < symbols[1]; i++)
            {
                symbolsFromAscii.Add(symbols[i]);
            }

            Console.WriteLine(string.Join(" ", symbolsFromAscii));

        }
    }
}
