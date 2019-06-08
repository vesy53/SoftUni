namespace p05._01.SlicingFile
{
    using System.IO;
    using System.Collections.Generic;

    class SlicingFile
    {
        static List<string> paths;

        static void Main(string[] args)
        {
            paths = new List<string>();

            string path = "../../sliceMe.mp4";
            string destination = "../../files/assembled.mp4";
            int parts = 4;

            Slice(path, destination, parts);

            Assemble(paths, destination);
        }

        static void Slice(string path, string destinationDirectory, int parts)
        {
            using (FileStream readFile = new FileStream(path, FileMode.Open))
            {
                long size = readFile.Length / parts + readFile.Length % parts;

                byte[] buffer = new byte[size];

                for (int i = 0; i < parts; i++)
                {
                    string destPath = destinationDirectory + $"Path{i}.mp4";

                    paths.Add(destPath);

                    using (FileStream writeFile = new FileStream(destPath, FileMode.Create))
                    {
                        int bytesCount = readFile.Read(buffer, 0, buffer.Length);

                        writeFile.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }

        static void Assemble(List<string> paths, string destinationDirectory)
        {
            byte[] buffer = new byte[1024];

            using (FileStream writeFile = new FileStream(destinationDirectory, FileMode.Create))
            {
                foreach (var path in paths)
                {
                    using (FileStream readFile = new FileStream(path, FileMode.Open))
                    {
                        while (true)
                        {
                            int bytesCount = readFile.Read(buffer, 0, buffer.Length);

                            if (bytesCount == 0)
                            {
                                break;
                            }

                            writeFile.Write(buffer, 0, bytesCount);
                        }
                    }
                }
            }
        }
    }
}