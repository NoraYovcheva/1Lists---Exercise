namespace _3._List_Operations
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
                string[] commansInput = input.Split();
                string commands = commansInput[0];

                if (commands == "Add")
                {
                    int elementForAdd = int.Parse(commansInput[1]);
                    numbers.Add(elementForAdd);
                }
                else if (commands == "Insert")
                {
                    int elementForInsert = int.Parse(commansInput[1]);
                    int index = int.Parse(commansInput[2]);
                    numbers.Insert(index, elementForInsert);
                }
                else if (commands == "Remove")
                {
                    int index = int.Parse(commansInput[1]);
                    numbers.Remove(index);
                }
                else if (commands == "Shift")
                {
                    string possition = commansInput[1];
                    int count = int.Parse(commansInput[2]);
                    if (possition == "Left")
                    {
                        for (int i = 1; i <= count; i++)
                        {
                            int numberOne = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(numberOne);
                        }
                    }
                    else if (commands == "Right")
                    {
                        for (int i = 0; i < length; i++)
                        {

                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
