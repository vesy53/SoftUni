using System;
using System.Collections.Generic;
using System.Linq;

class RecordUniqueNames2
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        string[] uniqNames = new string[num];

        for (int i = 0; i < num; i++)
        {
            string name = Console.ReadLine();

            uniqNames[i] = name;
        }

        Console.WriteLine(
            string.Join(Environment.NewLine, uniqNames.Distinct()));
    }
}

