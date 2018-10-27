using System;
using System.Collections.Generic;
using System.Linq;

class IntegerInsertion2
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
            int num = 0;
            int.TryParse(command, out num);
            int index = num;

            while (index > 10)
            {
                index /= 10;
            }

            if (index >= 0 && index < 10)
            {
                numbers.Insert(index, num);
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

