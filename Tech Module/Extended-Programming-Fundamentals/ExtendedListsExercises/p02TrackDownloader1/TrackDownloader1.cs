using System;
using System.Collections.Generic;
using System.Linq;

class TrackDownloader1
{
    static void Main(string[] args)
    {
        List<string> text = Console.ReadLine()
            .Split()
            .ToList();
        string inputCommands = Console.ReadLine();

        List<string> newList = new List<string>();

        while (inputCommands != "end")
        {
            for (int i = 0; i < text.Count; i++)
            {
                if (inputCommands.Contains(text[i]))
                {
                    break; 
                }

                if(i == text.Count - 1)
                {
                    newList.Add(inputCommands);
                }
            }

            inputCommands = Console.ReadLine();
        }

        newList.Sort();

        Console.WriteLine(string.Join("\r\n", newList));
        //second method per print
        //foreach (var list in newList)
        //{
        //    Console.WriteLine(list);
        //}
    }
}

