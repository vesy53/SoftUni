namespace p01._01.EvenLines
{
    using System;
    using System.IO;

    class EvenLines
    {
        static void Main(string[] args)
        {
            string path = "../../text.txt";

            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();

                int count = 0;

                while (line != null)
                {
                    if (count++ % 2 == 0)
                    {
                        line = line.Replace('-', '@')
                                   .Replace(',', '@')
                                   .Replace('.', '@')
                                   .Replace('!', '@')
                                   .Replace('?', '@');

                        string[] splitLine = line
                            .Split(' ');

                        for (int i = splitLine.Length - 1; i >= 0; i--)
                        {
                            string currentWord = splitLine[i];

                            Console.Write(currentWord + " ");
                        }

                        Console.WriteLine();
                    }

                    line = reader.ReadLine();
                }
            }
        }
    }
}
