namespace P07._01.Pyramidic
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Pyramidic
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            List<string> lines = new List<string>();
            List<string> result = new List<string>();

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();

                lines.Add(input);
            }

            for (int i = 0; i < lines.Count; i++)
            {
                string currentLine = lines[i];

                for (int j = 0; j < currentLine.Length; j++)
                {
                    char currentChar = currentLine[j];

                    int count = 1;

                    string currentPyramid = string.Empty;

                    for (int k = i; k < lines.Count; k++)
                    {
                        string currentCount = new string(currentChar, count);

                        if (lines[k].Contains(currentCount))
                        {
                            currentPyramid += currentCount + Environment.NewLine;
                        }
                        else
                        {
                            break;
                        }

                        count += 2;
                    }

                    result.Add(currentPyramid.Trim());
                }
            }

            Console.WriteLine(result.OrderByDescending(x => x.Length).First());
        }
    }
}
