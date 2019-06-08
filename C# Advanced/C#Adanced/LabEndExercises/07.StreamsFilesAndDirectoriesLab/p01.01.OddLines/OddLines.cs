namespace p01._01.OddLines
{
    using System.IO;

    class OddLines
    {
        static void Main(string[] args)
        {
            string pathInput = "../../files/text.txt";
            string pathOutput = "../../files/oddLines.txt";

            StreamReader reader = new StreamReader(pathInput);

            using (reader)
            {
                StreamWriter writer = new StreamWriter(pathOutput);

                using (writer)
                {
                    string line = reader.ReadLine();

                    int count = 0;

                    while (line != null)
                    {
                        if (count++ % 2 != 0)
                        {
                            writer.WriteLine(line);
                        }

                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
