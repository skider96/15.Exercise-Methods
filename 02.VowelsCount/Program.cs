namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> first = new List<char>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                char letters = input[i];
                // a, e, i, o, and u
                if (letters == 'a' || letters == 'e' || letters == 'i' || letters == 'o' || letters == 'u' ||
                    letters == 'A' || letters == 'E' || letters == 'I' || letters == 'O' || letters == 'U')
                {
                    first.Add(letters);
                }
            }
            System.Console.WriteLine(first.Count);
        }
        public static List<int> ReadList()
        {
            return Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToList();
        }
    }
}
