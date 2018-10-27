using System;
using System.Collections.Generic;
using System.Linq;

class IntegerInsertion
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        string command = Console.ReadLine();

        while (command != "end")
        {
            char symbol = '\0';

            foreach (var item in command)
            {
                symbol = item;
                break;
            }
         
            int newIndex = symbol - 48;
            int currentNum = int.Parse(command); 

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == newIndex)
                {                  
                    numbers.Insert(i, currentNum);
                    break;
                }
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

