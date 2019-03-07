using System;
using System.Linq;

class ArrayContainsElement
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int searchNum = int.Parse(Console.ReadLine());
        bool isFound = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == searchNum)
            {
                isFound = true;
                break;
            }
        }

        if (isFound)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

