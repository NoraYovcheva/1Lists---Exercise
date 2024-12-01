namespace _1._Change_List2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commandsInput = input.Split();
                string commands = commandsInput[0];

                if (commands == "Delete")
                {
                    int elementForDelete = int.Parse(commandsInput[1]);
                    numbers.RemoveAll(element => element == elementForDelete);
                }
                else if (commands == "Insert")
                {
                    int elemenetForInsert = int.Parse(commandsInput[1]);
                    int index = int.Parse(commandsInput[2]);
                    numbers.Insert(index, elemenetForInsert);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
