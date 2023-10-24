namespace _07.NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a method that receives a single integer n and prints an NxN matrix using this number as a filler.

            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(n);
                }
                Console.WriteLine();
            }
        }
    }
}
