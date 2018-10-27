using System;
using System.Collections.Generic;

class RecordUniqueNames1
{
    static void Main(string[] args)
    {
        List<string> uniqNames = new List<string>();
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            string name = Console.ReadLine();

            if (!uniqNames.Contains(name))
            {
                uniqNames.Add(name);
            }
        }

        Console.WriteLine(string.Join(Environment.NewLine, uniqNames));
    }
}

