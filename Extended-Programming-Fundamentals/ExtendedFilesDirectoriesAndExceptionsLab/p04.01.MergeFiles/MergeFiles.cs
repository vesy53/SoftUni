namespace p04._01.MergeFiles
{
    using System;
    using System.IO;
    using System.Linq;

    class MergeFiles
    {
        static void Main(string[] args)
        {
            //string firstText = "1" + Environment.NewLine 
            //    + "3" + Environment.NewLine 
            //    + "5";
            //string secondText = "2" + Environment.NewLine
            //    + "4" + Environment.NewLine
            //    + "6";
            //
            //File.WriteAllText("input1.txt", firstText);
            //File.WriteAllText("input2.txt", secondText);

            string[] firstArr = File
                .ReadAllLines("input1.txt");
            string[] secandArr = File
                .ReadAllLines("input2.txt");
            
            string[] mergeFiles = firstArr
                .Concat(secandArr)
                .OrderBy(x => x)
                .ToArray();
            
            File.AppendAllText("merge-files.txt",
                string.Join(Environment.NewLine, mergeFiles));
        }
    }
}
