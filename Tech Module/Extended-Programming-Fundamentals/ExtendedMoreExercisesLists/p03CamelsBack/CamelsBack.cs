using System;
using System.Collections.Generic;
using System.Linq;

class CamelsBack
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        int camelBackSize = int.Parse(Console.ReadLine());

        int rounds = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            if (camelBackSize == numbers.Count)
            {
                break;
            }
            else
            {
                rounds++;
                numbers.RemoveAt(i);
                numbers.RemoveAt(numbers.Count - 1);              
                i--;
            }
        }

        if (rounds >= 1)
        {
            Console.WriteLine($"{rounds} rounds");
            Console.WriteLine("remaining: " + string.Join(" ", numbers));
        }
        else
        {
            Console.WriteLine("already stable: " + string.Join(" ", numbers));
        }
    }
}

