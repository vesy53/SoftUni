using System;
using System.Collections.Generic;
using System.Linq;

class TrackDownloader
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
            bool isContains = false;

            for (int i = 0; i < text.Count; i++)               
            {
                if (inputCommands.Contains(text[i]))
                {
                    isContains = true;
                }
            }

            if (!isContains)
            {
                newList.Add(inputCommands);
            }

            inputCommands = Console.ReadLine();
        }

        newList.Sort();
        Console.WriteLine(string.Join("\r\n", newList));
    }
}

