namespace p04._01.MergeFiles
{
    using System;

    class MergeFiles
    {
        static void Main(string[] args)
        {
            string input1Path = "../../input1.txt";
            string input2Path = "../../input2.txt";
            string outputPath = "../../output.txt";

            using (StraemReader reader = new StraemReader(input1Path))
            {
                using (StraemReader reader2 = new StraemReader(input2Path))
                {
                    using (StreamWriter writer = new StreamWriter(outputPath))
                    {
                        string firstFileLine = firstReader.ReadLine();
                        string secondFileLine = secondReader.ReadLine();

                        while (firstFileLine != null && secondFileLine != null)
                        {
                            writer.WriteLine(firstFileLine);
                            writer.WriteLine(secondFileLine);
                        }
                    }
                }
            }
        }
    }
}
