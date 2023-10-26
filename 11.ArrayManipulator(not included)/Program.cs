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

                    }
                    else if (arguments[1] == "odd")
                    {

                    }
                }
            }
        }
    }
}
