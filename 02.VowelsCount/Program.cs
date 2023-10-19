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

                first += letters;

            }



            System.Console.WriteLine(first[1]);

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
