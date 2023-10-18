namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> first = ReadList();
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
