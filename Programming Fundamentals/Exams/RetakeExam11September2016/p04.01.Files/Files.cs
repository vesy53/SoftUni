namespace p04._01.Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Files
    {
        static void Main(string[] args)
        {
            var dataFiles = new Dictionary<string, Dictionary<string, long>>();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(';');
                long size = long.Parse(input[1]);

                string[] tokensFile = input[0]
                    .Split('\\');
                string root = tokensFile[0];
                string extension = tokensFile[tokensFile.Length - 1];

                if (!dataFiles.ContainsKey(root))
                {
                    dataFiles.Add(root, new Dictionary<string, long>());
                }

                if (!dataFiles[root].ContainsKey(extension))
                {
                    dataFiles[root].Add(extension, 0);
                }

                dataFiles[root][extension] = size;
            }

            string[] commandTokens = Console.ReadLine()
                .Split(new string[] { " in " },
                    StringSplitOptions
                    .RemoveEmptyEntries);
            string currExtension = commandTokens[0];
            string currRoot = commandTokens[1];

            bool isЕxists = false;

            foreach (var file in dataFiles
                .Where(x => x.Key == currRoot)
                .OrderByDescending(x => x.Value.Values)
                .ThenBy(x => x.Value.Keys))
            {
                Dictionary<string, long> filesElements = file.Value;

                foreach (var element in filesElements
                    .Where(x => x.Key.EndsWith(currExtension))
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {
                    string extencion = element.Key;
                    long size = element.Value;

                    Console.WriteLine($"{extencion} - {size} KB");
                    
                    isЕxists = true;
                }
            }

            if (isЕxists == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
