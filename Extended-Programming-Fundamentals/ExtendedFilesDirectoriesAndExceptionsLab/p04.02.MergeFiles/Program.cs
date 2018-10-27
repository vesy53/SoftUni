namespace p04._02.MergeFiles
{
    using System;
    using System.IO;

    class Program
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


            string[] firstFile = File.ReadAllLines("input1.txt");
            string[] secondFile = File.ReadAllLines("input2.txt");

            File.WriteAllText("result.txt", string.Empty);

            for (int i = 0; i < firstFile.Length; i++)
            {
                File.AppendAllText
                (
                    "result.txt", 
                    firstFile[i] + 
                    Environment.NewLine +
                    secondFile[i] + 
                    Environment.NewLine
                );
            }
        }
    }
}
