namespace p04._03.Files
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Files3
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            List<File> files = new List<File>();

            for (int i = 0; i < num; i++)
            {
                string[] inputTokens = Console.ReadLine()
                    .Split(';');
                long size = long.Parse(inputTokens[1]);

                string[] filesElements = inputTokens[0]
                    .Split('\\');
                string root = filesElements[0];
                string name = filesElements[filesElements.Length - 1];

                File currentFile = new File
                (
                    root, 
                    name, 
                    size
                );

                files.Add(currentFile);
            }

            string[] command = Console.ReadLine()
                .Split();
            string extension = command.First();
            string rootCommand = command.Last();

            var results = new Dictionary<string, long>();

            foreach (var file in files)
            {
                if (file.Root.Equals(rootCommand) &&
                    file.Name.EndsWith(extension))
                {
                    string name = file.Name;
                    long size = file.Size;

                    results[name] = size;
                }
            }

            if (results.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var item in results
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {

                    string fileName = item.Key;
                    long fileSize = item.Value;

                    Console.WriteLine($"{fileName} - {fileSize} KB");
                }
            }
        }
    }

    class File
    {
        public string Root { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }

        public File(string root, string name, long size)
        {
            this.Root = root;
            this.Name = name;
            this.Size = size;
        }
    }
}
