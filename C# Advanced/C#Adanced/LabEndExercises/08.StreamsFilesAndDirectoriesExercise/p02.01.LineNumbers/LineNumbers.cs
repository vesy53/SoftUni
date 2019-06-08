namespace p02._01.LineNumbers
{
    using System;
    using System.IO;

    class LineNumbers
    {
        static void Main(string[] args)
        {
            string textPath = "../../text.txt";
            string outputPath = "../../output.txt";

            using (StreamReader reader = new StreamReader(textPath))
            {
                using (StreamWriter writer = new StreamWriter(outputPath))
                {
                    string line = reader.ReadLine();

                    int counter = 0;

                    while (line != null)
                    {
                        int countCharacters = 0;
                        int countPunctuations = 0;

                        foreach (char symbol in line)
                        {
                            if (symbol >= 'a' && 
                                symbol <= 'z' ||
                                symbol >= 'A' &&
                                symbol <= 'Z')
                            {
                                countCharacters++;
                            }
                            else if (symbol == '-' ||
                                symbol == ',' ||
                                symbol == '.' ||
                                symbol == '!' ||
                                symbol == '?' ||
                                symbol == '\'')
                            {
                                countPunctuations++;
                            }
                        }

                        writer.WriteLine(
                            $"Line {++counter}: {line} ({countCharacters})({countPunctuations})");

                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
