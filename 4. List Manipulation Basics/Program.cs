namespace _4._List_Manipulation_Basics
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
                else if (commands == "Remove")
                {
                    int elementForRemove = int.Parse(commansInput[1]);
                    numbers.Remove(elementForRemove);
                }
                else if (commands == "RemoveAt")
                {
                    int index = int.Parse (commansInput[1]);
                    numbers.RemoveAt(index);
                }
                else if (commands == "Insert")
                {
                    int elementForInsert = int.Parse(commansInput[1]);
                    int index = int.Parse(commansInput[2]);
                    numbers.Insert(index, elementForInsert);
                }
            
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
