namespace p02._01.LineNumbers
{
    using System;
    using System.IO;

    class LineNumbers

    {
        static void Main(string[] args)
        {
            string pathInput = "../../files/text.txt";
            string pathOutput = "../../files/outputText.txt";

            StreamReader reader = new StreamReader(pathInput);

            using (reader)
            {
                StraemWriter writer = new StraemWriter(pathOutput);

                using (writer)
                {
                    string line = reader.ReadLine();

                    int count = 1;

                    while (line != null)
                    {
                        writer.WriteLine($"{count++}. {line}");
                    
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
