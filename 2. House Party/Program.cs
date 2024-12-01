namespace _2._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandCount = int.Parse(Console.ReadLine());

            List<string> guestList = new List<string>();

            for (int count = 1; count <= commandCount; count++)
            {
                string command = Console.ReadLine();
                string[] commands = command.Split();
                string name = commands[0];

                if (commands.Length == 3)
                {
                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(name);
                    }
                }
                else if (commands.Length == 4) 
                {
                    if (guestList.Contains(name))
                    {
                        guestList.Remove(name);
                    }
                    else 
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            foreach (string guestName in guestList)
            {
                Console.WriteLine(guestName);
            }
        }
    }
}
