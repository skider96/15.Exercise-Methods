namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args, string? s)
        {
            char startNumber = char.Parse(Console.ReadLine());
            char finalNumber = char.Parse(Console.ReadLine());
            List<char> symbolsFromAscii = new List<char>();
            int middleNumber = 0;
            if (startNumber > finalNumber)
            {
               middleNumber = startNumber - finalNumber;
               for (int i = finalNumber; i < startNumber; i++)
               {
                   symbolsFromAscii.Add((char)i);
               }
            }
            else
            {
                for (int i = startNumber +1; i < finalNumber; i++)
                {
                    symbolsFromAscii.Add((char)i);
                }
            }

            //else
            //{
            //    middleNumber = finalNumber - startNumber;
            //}

            Console.WriteLine(string.Join(" ", symbolsFromAscii));

        }
    }
}
