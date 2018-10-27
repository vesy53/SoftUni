namespace p05ArrayManipulator1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string[] inputCommands = Console.ReadLine()
                .Split()
                .ToArray();

            while (inputCommands[0] != "print")
            {
                string command = inputCommands[0];

                if (command.Equals("add"))
                {
                    int index = int.Parse(inputCommands[1]);
                    int element = int.Parse(inputCommands[2]);

                    numbers.Insert(index, element);
                }
                else if (command.Equals("addMany"))
                {
                    int index = int.Parse(inputCommands[1]);
                    List<int> elements = inputCommands
                        .Skip(2)
                        .Take(inputCommands.Length - 2)
                        .Select(int.Parse)
                        .ToList();

                    numbers.InsertRange(index, elements);
                }
                else if (command.Equals("contains"))
                {
                    int element = int.Parse(inputCommands[1]);
                    int index = numbers.IndexOf(element);

                    Console.WriteLine(index);
                }
                else if (command.Equals("remove"))
                {
                    int index = int.Parse(inputCommands[1]);

                    numbers.RemoveAt(index);
                }
                else if (command.Equals("shift"))
                {
                    int position = int.Parse(inputCommands[1]);
                    int count = position % numbers.Count;

                    for (int i = 0; i < count; i++)
                    {
                        numbers.Add(numbers[i]);
                        numbers.RemoveAt(0);
                    }
                }
                else if (command.Equals("sumPairs"))
                {
                    List<int> sumPairs = new List<int>();

                    for (int i = 0; i < numbers.Count; i += 2)
                    {
                        int currentElement = numbers[i];
                        int nextElement = 0;
                        //подсигуряваме се да не би да излезнем извън дължината на листа
                        if (i < numbers.Count - 1)
                        {
                            nextElement = numbers[i + 1];
                        }

                        int sumElement = currentElement + nextElement;

                        sumPairs.Add(sumElement);
                    }

                    numbers = sumPairs;
                }

                inputCommands = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }
    }
}
