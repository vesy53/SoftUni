namespace p06._01.FullDirectoryTraversal
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;

    class FullDirectoryTraversal  
    {
        static void Main(string[] args)
        {
            //string path = Console.ReadLine();
            string path = "../../../";

            var filesInfo = new Dictionary<string, List<FileInfo>>();

            string[] files = Directory
                .GetFiles(
                    path, 
                    "*.*", 
                    SearchOption.AllDirectories);

            foreach (string file in files)
            {
                FileInfo info = new FileInfo(file);
                string infoExtension = info.Extension;

                if (!filesInfo.ContainsKey(infoExtension))
                {
                    filesInfo.Add(infoExtension, new List<FileInfo>());
                }

                filesInfo[infoExtension].Add(info);
            }

            string pathToDesktop = Environment
                .GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt";

            using (StreamWriter writer = new StreamWriter(pathToDesktop))
            {
                foreach (var fileInfo in filesInfo
                    .OrderByDescending(x => x.Value.Count)
                    .ThenBy(x => x.Key))
                {
                    string file = fileInfo.Key;
                    List<FileInfo> fileInfos = fileInfo.Value;

                    writer.WriteLine(file);

                    foreach (FileInfo info in fileInfos
                        .OrderBy(x => x.Length))
                    {
                        string infoName = info.Name;
                        long infoLength = info.Length;

                        writer.WriteLine(
                            $"--{infoName} - {(infoLength / 1024):F3}kb");
                    }
                }
            }
        }
    }
}