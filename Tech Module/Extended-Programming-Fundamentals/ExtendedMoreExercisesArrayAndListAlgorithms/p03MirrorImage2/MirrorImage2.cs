using System;
using System.Collections.Generic;
using System.Linq;

class MirrorImage2
{
    static void Main(string[] args)
    {
        List<string> numbers = Console.ReadLine()
             .Split()
             .ToList();
        string command = Console.ReadLine();

        while (command != "Print")
        {
            int index = int.Parse(command);
            List<string> numsList = new List<string>();

            for (int i = 0; i <= index; i++)
            {
                if (i < index)
                {
                    numsList.Insert(0, numbers[i]);
                }

                if (i == index)
                {
                    numsList.Add(numbers[i]);
                }
            }

            for (int i = numbers.Count - 1; i > index; i--)
            {
                numsList.Add(numbers[i]);
            }

            numbers = numsList;

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

