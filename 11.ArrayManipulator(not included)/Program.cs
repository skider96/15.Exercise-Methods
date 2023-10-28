using System.Linq;
namespace _11.ArrayManipulator_not_included_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                int index = 0;
                string[] arguments = command.Split();
                List<int> oddOrEvenNumbers = new List<int>();
                if (arguments[0] == "exchange")
                {
                    index = int.Parse(arguments[1]);
                    if (index < 0 || index >= list.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        List<int> partOfList = new List<int>();
                        partOfList = list.GetRange(index, list.Count - 1);
                        list.RemoveRange(index, list.Count - 1);
                        list.InsertRange(0, partOfList);
                    }
                }
                else if (arguments[0] == "max")
                {

                    if (arguments[1] == "even")
                    {
                        AddingEvenNumberInList(list, oddOrEvenNumbers);
                        printMaxNumber(oddOrEvenNumbers);
                    }
                    else if (arguments[1] == "odd")
                    {
                        addingOddNumberInList(list, oddOrEvenNumbers);
                        printMaxNumber(oddOrEvenNumbers);
                    }
                }
                else if (arguments[0] == "min")
                {
                    if (arguments[1] == "even")
                    {
                        AddingEvenNumberInList(list, oddOrEvenNumbers);
                        PrintMinNumber(oddOrEvenNumbers);
                    }
                    else if (arguments[1] == "odd")
                    {
                        addingOddNumberInList(list, oddOrEvenNumbers);
                        PrintMinNumber(oddOrEvenNumbers);
                    }
                }
                // else if ()
                // {
                    
                // }
            }
        }

        private static void PrintMinNumber(List<int> oddOrEvenNumbers)
        {
            int minOddOrENumber = oddOrEvenNumbers.Min();
            System.Console.WriteLine(minOddOrENumber);
            oddOrEvenNumbers.Clear();
        }

        private static void addingOddNumberInList(List<int> list, List<int> oddOrEvenNumbers)
        {
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    oddOrEvenNumbers.Add(list[i]);
                }
            }
        }

        private static void AddingEvenNumberInList(List<int> list, List<int> oddOrEvenNumbers)
        {
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    oddOrEvenNumbers.Add(list[i]);
                }
            }
        }

        private static void printMaxNumber(List<int> oddOrEvenNumbers)
        {
            int maxOddOrENumber = oddOrEvenNumbers.Max();
            System.Console.WriteLine(maxOddOrENumber);
            oddOrEvenNumbers.Clear();
        }
    }
}
