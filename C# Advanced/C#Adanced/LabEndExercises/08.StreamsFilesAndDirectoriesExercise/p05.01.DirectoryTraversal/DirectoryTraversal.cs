namespace p05._01.DirectoryTraversal
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;

    class DirectoryTraversal
    {
        static void Main(string[] args)
        {
            var directoryInfo = new Dictionary<string, Dictionary<string, decimal>>();

            string[] files = Directory.GetFiles("../../../",
                "*.*",   //regex pattern
                SearchOption.TopDirectoryOnly);
            // SearchOption.AllDirectories);

            foreach (string file in files)
            {
                FileStream currFile = File.Open(file, FileMode.Open);

                string fullName = Path.GetFileName(file);
                string extension = Path.GetExtension(file);

                Decimal fileSize = Decimal.Divide(currFile.Length, 1024);

                if (!directoryInfo.ContainsKey(extension))
                {
                    directoryInfo.Add(extension, new Dictionary<string, decimal>());
                }

                if (!directoryInfo[extension].ContainsKey(fullName))
                {
                    directoryInfo[extension].Add(fullName, fileSize);
                }
            }

            string path = Environment
                .GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt";

            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (var directory in directoryInfo
                    .OrderByDescending(x => x.Value.Count)
                    .ThenBy(x => x.Key))
                {
                    string extension = directory.Key;
                    Dictionary<string, decimal> dyrectoryData = directory.Value;

                    writer.WriteLine(extension);

                    foreach (var fileInfo in dyrectoryData
                        .OrderBy(x => x.Value))
                    {

                        string fileName = fileInfo.Key;
                        decimal size = fileInfo.Value;

                        writer.WriteLine($"--{fileName} - {size:F2}kb");
                    }
                }
            }
        }
    }
}