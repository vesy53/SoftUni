namespace p02._02.SantasGifts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SantasGifts2
    {
        static void Main(string[] args)
        {
            byte commNum = byte.Parse(Console.ReadLine());
            List<int> houses = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<string> commands = new List<string>();

            while (commNum-- > 0)
            {
                commands.Add(Console.ReadLine());
            }

            int position = 0;

            foreach (string line in commands)
            {
                string[] command = line.Split();

                if (command.Length == 2)
                {
                    int value = int.Parse(command[1]);

                    if (command[0] == "Forward")
                    {
                        if (position + value >= 0 &&
                            position + value < houses.Count)
                        {
                            position += value;
                            houses.RemoveAt(position);
                        }
                    }
                    else if (command[0] == "Back")
                    {
                        if (position - value >= 0 &&
                            position - value < houses.Count)
                        {
                            position -= value;
                            houses.RemoveAt(position);
                        }
                    }
                }
                else if (command.Length == 3)
                {
                    if (command[0] == "Gift")
                    {
                        int index = int.Parse(command[1]);
                        int value = int.Parse(command[2]);

                        if (index >= 0 && index < houses.Count)
                        {
                            position = index;
                            houses.Insert(index, value);
                        }
                    }
                    else if (command[0] == "Swap")
                    {
                        int value1 = int.Parse(command[1]);
                        int value2 = int.Parse(command[2]);

                        if (houses.Contains(value1) &&
                            houses.Contains(value2))
                        {
                            int val1Index = houses.IndexOf(value1);
                            int val2Index = houses.IndexOf(value2);

                            houses[val1Index] = value2;
                            houses[val2Index] = value1;
                        }
                    }
                }
            }

            Console.WriteLine($"Position: {position}");
            Console.WriteLine(string.Join(", ", houses));
        }
    }
}
