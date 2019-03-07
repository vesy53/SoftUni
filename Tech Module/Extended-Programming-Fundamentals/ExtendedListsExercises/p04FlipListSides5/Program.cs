using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> numbers = Console.ReadLine()
           .Split(' ')
           .ToList();

        string firstElement = numbers[0];
        string lastElement = numbers[numbers.Count - 1];
        numbers.Reverse();
        numbers[0] = firstElement;
        numbers[numbers.Count - 1] = lastElement;

        Console.WriteLine(string.Join(" ", numbers));
    }
}

