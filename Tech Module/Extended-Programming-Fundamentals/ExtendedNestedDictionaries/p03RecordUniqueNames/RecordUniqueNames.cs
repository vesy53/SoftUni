using System;
using System.Collections.Generic;

class RecordUniqueNames
{
    static void Main(string[] args)
    {
        HashSet<string> uniqNames = new HashSet<string>();
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            string name = Console.ReadLine();

            uniqNames.Add(name);
        }

        foreach (var name in uniqNames)
        {
            Console.WriteLine(name);
        }

        //second method per print
        //Console.WriteLine(string.Join(Environment.NewLine, uniqNames));
    }
}

