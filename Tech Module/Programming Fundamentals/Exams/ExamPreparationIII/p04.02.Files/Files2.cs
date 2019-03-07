using System;
using System.Collections.Generic;
using System.Linq;

namespace p04._02.Files
{
    class Files2
    {
        static void Main(string[] args)
        {
            var filesData = new Dictionary<string, Dictionary<string, long>>();
            
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input
                    .Split(';');
                long size = long.Parse(tokens[1]);

                string[] filesElements = tokens[0]
                    .Split('\\');
                string root = filesElements[0];
                string nameExtencion = filesElements[filesElements.Length - 1];

                if (!filesData.ContainsKey(root))
                {
                    filesData.Add(root, new Dictionary<string, long>());
                }

                filesData[root][nameExtencion] = size;
            }

            string[] commandTokens = Console.ReadLine()
                .Split(new string[] { " in " },
                    StringSplitOptions
                    .RemoveEmptyEntries);
            string extension = commandTokens[0];
            string rootCommand = commandTokens[1];         

            bool isTrue = false;

            foreach (var file in filesData
                .Where(x => x.Key == rootCommand))
            {
                string root = file.Key;
                Dictionary<string, long> filesElements = file.Value;

                foreach (var element in filesElements
                    .Where(x => x.Key.Contains($".{extension}"))
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {
                    string filesExtension = element.Key;
                    long size = element.Value;
                    isTrue = true;

                    Console.WriteLine($"{filesExtension} - {size} KB");
                }
            }

            if (isTrue == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
