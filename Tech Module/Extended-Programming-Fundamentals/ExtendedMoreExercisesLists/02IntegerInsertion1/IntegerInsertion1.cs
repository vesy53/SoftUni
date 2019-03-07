using System;
using System.Collections.Generic;
using System.Linq;

class IntegerInsertion1
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
            int currentNum = int.Parse(command);
            int index = int.Parse(command.Substring(0, 1));

            numbers.Insert(index, currentNum);

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

