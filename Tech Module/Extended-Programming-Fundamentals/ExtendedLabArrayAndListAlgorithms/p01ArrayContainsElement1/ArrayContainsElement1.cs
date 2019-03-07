using System;
using System.Linq;

class ArrayContainsElement1
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int searchNum = int.Parse(Console.ReadLine());
        bool isFound = false;

        foreach (var num in numbers)
        {
            if (num == searchNum)
            {
                isFound = true;
                break;
            }
        }

        var result = isFound ? "yes" : "no";

        Console.WriteLine(result);
    }
}

