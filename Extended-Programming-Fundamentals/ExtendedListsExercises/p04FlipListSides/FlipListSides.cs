using System;
using System.Collections.Generic;
using System.Linq;

class FlipListSides
{
    static void Main(string[] args)
    {
        List<string> numbers = Console.ReadLine()
            .Split()
            .ToList();

        List<string> reversedList = new List<string>();     
        string firstNum = numbers[0];
        string lastNum = numbers[numbers.Count - 1];
         
        numbers.Reverse();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (i == 0)
            {
                numbers.Remove(numbers[0]);                   
            }

            if (i == numbers.Count - 1)
            {
                numbers.Remove(numbers[numbers.Count - 1]);
            }
        }

        reversedList.Add(firstNum);
        reversedList.AddRange(numbers);
        reversedList.Add(lastNum);

        Console.WriteLine(string.Join(" ", reversedList));
    }
}

