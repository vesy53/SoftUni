namespace p02._01.AnonymousThreat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AnonymousThreat
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split()
                .ToList();
            string input = Console.ReadLine();

            while (input.Equals("3:1") == false)
            {
                string[] tokens = input
                    .Split();
                string command = tokens[0];

                switch (command)
                {
                    case "merge":
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);

                        startIndex = ValidateIndex(startIndex, elements.Count);
                        endIndex = ValidateIndex(endIndex, elements.Count);

                        string concatElments = string.Empty;

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            concatElments += elements[i];
                        }

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            elements.RemoveAt(startIndex);
                        }

                        elements.Insert(startIndex, concatElments);
                        break;
                    case "divide":
                        int index = int.Parse(tokens[1]);
                        int partitionsCount = int.Parse(tokens[2]);

                        List<string> partitions = SplitedEqual(elements[index], partitionsCount);
                        elements.RemoveAt(index);
                        elements.InsertRange(index, partitions);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", elements));
        }

        static List<string> SplitedEqual(string word, int partitionsCount)
        {
            List<string> result = new List<string>();
            int part = word.Length / partitionsCount;

            while (word.Length >= part)
            {
                result.Add(word.Substring(0, part));
                word = word.Substring(part);
            }

            if (word != "")
            {
                result.Add(word);
            }

            if (result.Count == partitionsCount)
            {
                return result;
            }
            else
            {
                string concatLasTwoElements =
                    result[result.Count - 2] + result[result.Count - 1];
                result.RemoveRange(result.Count - 2, 2);
                result.Add(concatLasTwoElements);
                return result;
            }
        }

        static int ValidateIndex(int index, int length)
        {
            if (index < 0)
            {
                index = 0;
            }
            else if (index > length - 1)
            {
                index = length - 1;
            }

            return index;
        }
    }
}
