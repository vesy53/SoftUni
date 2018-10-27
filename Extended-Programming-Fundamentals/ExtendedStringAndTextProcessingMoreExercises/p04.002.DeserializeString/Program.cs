namespace p04._002.DeserializeString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<char, List<int>>();

            string input = Console.ReadLine();

            int lastIndex = int.MinValue;

            while (input.Equals("end") == false)
            {
                string[] inputTokens = input
                    .Split(':');

                char @char = inputTokens[0][0];
                List<int> indexes = inputTokens[1]
                    .Split('/')
                    .Select(int.Parse)
                    .ToList();

                data.Add(@char, new List<int>(indexes));

                if (indexes.Max() > lastIndex)
                {
                    lastIndex = indexes.Max();
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("", Result(data, lastIndex)));
        }

        static List<string> Result(Dictionary<char, List<int>> data, int lastIndex)
        {
            List<string> result = new List<string>();

            for (int i = 0; i <= lastIndex; i++)
            {
                result.Add(String.Empty);
            }

            foreach (KeyValuePair<char, List<int>> item in data)
            {
                char @char = item.Key;
                List<int> indexes = item.Value;

                for (int i = 0; i < indexes.Count; i++)
                {
                    result[indexes[i]] = @char.ToString();
                }
            }

            return result;
        }
    }
}
