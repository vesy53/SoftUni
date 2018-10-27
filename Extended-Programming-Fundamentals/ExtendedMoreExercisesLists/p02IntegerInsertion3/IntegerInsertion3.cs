using System;
using System.Collections.Generic;
using System.Linq;

class IntegerInsertion3
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
            int index = int.Parse(command);
            int currentNum = index;

            while (index > 10)
            {
                index /= 10;
            }

            numbers.Insert(index, currentNum);

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

