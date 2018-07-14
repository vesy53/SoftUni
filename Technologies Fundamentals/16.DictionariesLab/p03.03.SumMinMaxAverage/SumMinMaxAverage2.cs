using System;
using System.Collections.Generic;
using System.Linq;

class SumMinMaxAverage2
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        LinkedList<int> numbers = new LinkedList<int>();

        for (int i = 0; i < num; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());
            
            numbers.AddLast(currentNum);
        }

        Console.WriteLine($"Sum = {numbers.Sum()}");
        Console.WriteLine($"Min = {numbers.Min()}");
        Console.WriteLine($"Max = {numbers.Max()}");
        Console.WriteLine($"Average = {numbers.Average()}");
    }
}

