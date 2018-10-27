namespace p04._04.Files
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Files4
    {
        static void Main(string[] args)
        {
            var dataFiles = new Dictionary<string, List<File>>();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] inputTokens = Console.ReadLine()
                    .Split(';'); 
                long size = long.Parse(inputTokens[1]);

                string[] filesElements = inputTokens[0]
                    .Split('\\');
                string root = filesElements[0];
                string fileName = filesElements[filesElements.Length - 1];

                if (!dataFiles.ContainsKey(root))
                {
                    dataFiles.Add(root, new List<File>());
                }

                File currentFile = new File(fileName, size);

                dataFiles[root].Add(currentFile);
            }

            string debug = "";
            string[] command = Console.ReadLine()
                .Split();
            string extension = command.First();
            string rootCommand = command.Last();

            foreach (var file in dataFiles
                .Where(x => x.Key == rootCommand))
            {
                
            }
        }
    }

    class File
    {
        public string Name { get; set; }
        public long Size { get; set; }

        public File(string name, long size)
        {
            this.Name = name;
            this.Size = size;
        }
    }
}
