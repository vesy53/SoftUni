namespace p05ArrayManipulator
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
                .Split();

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
                    List<int> element = new List<int>();

                    for (int i = 2; i < inputCommands.Length; i++)
                    {
                        element.Add(int.Parse(inputCommands[i]));
                    }              
                     
                    numbers.InsertRange(index, element);
                }
                else if (command.Equals("contains"))
                {
                    int element = int.Parse(inputCommands[1]);

                    if (numbers.Contains(element))
                    {
                        Console.WriteLine(numbers.IndexOf(element));
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if (command.Equals("remove"))
                {
                    int index = int.Parse(inputCommands[1]);

                    numbers.RemoveAt(index);
                }
                else if (command.Equals("shift"))
                {
                    int positions = int.Parse(inputCommands[1]);

                    for (int i = 0; i < positions; i++)
                    {
                        int firstElement = numbers[0];

                        for (int j = 0; j < numbers.Count - 1; j++)
                        {
                            numbers[j] = numbers[j + 1];
                        }

                        numbers[numbers.Count - 1] = firstElement;
                    }
                }
                else if (command.Equals("sumPairs"))
                {
                    int sum = 0;

                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        sum = numbers[i] + numbers[i + 1];
                        numbers.RemoveAt(i);
                        numbers[i] = sum;
                    }
                }

                inputCommands = Console.ReadLine().Split();
            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }
    }
}
