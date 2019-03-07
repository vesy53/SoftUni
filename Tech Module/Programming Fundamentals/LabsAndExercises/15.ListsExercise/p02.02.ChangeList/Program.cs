using System;
using System.Collections.Generic;
using System.Linq;

namespace p02ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string[] command = Console.ReadLine()
                .Split();


            while (command[0] != "Odd" && command[0] != "Even")
            {                
                if (command[0].Equals("Delete"))
                {
                    int element = int.Parse(command[1]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == element)
                        {
                            numbers.Remove(numbers[i]);
                            i--;
                        }
                    }
                }
                else if (command[0].Equals("Insert"))
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);

                    numbers.Insert(position, element);
                }

                command = Console.ReadLine().Split();
            }

            if (command[0] == "Odd")
            {
                numbers.RemoveAll(x => x % 2 == 0);
            }
            else if (command[0] == "Even")
            {
                numbers.RemoveAll(x => x % 2 != 0);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

