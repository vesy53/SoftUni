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
                .Split()
                .ToArray();


            while (command[0] != "Odd" || command[0] != "Even")
            {
                if (command[0] == "Odd")
                {
                    numbers.RemoveAll(x => x % 2 == 0);
                    break;
                }
                else if (command[0] == "Even")
                {
                    numbers.RemoveAll(x => x % 2 != 0);
                    break;
                }
                else if (command[0] == "Delete")
                {
                    int element = int.Parse(command[1]);
                    numbers.RemoveAll(x => x == element);                 
                }
                else if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);

                    numbers.Insert(position, element);
                }

                command = Console.ReadLine().Split().ToArray(); 
            }
         
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
