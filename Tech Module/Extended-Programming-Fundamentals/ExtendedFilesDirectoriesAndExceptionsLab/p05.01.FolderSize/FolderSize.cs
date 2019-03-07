namespace p05._01.FolderSize
{
    using System;
    using System.Linq;
    using System.IO;

    class FolderSize
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("TestFolde");

            double sum = 0.0;

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);

                sum += fileInfo.Length;
            }

            sum = sum / 1024 / 1024;

            File.WriteAllText("result.txt", sum.ToString());
        }
    }
}
