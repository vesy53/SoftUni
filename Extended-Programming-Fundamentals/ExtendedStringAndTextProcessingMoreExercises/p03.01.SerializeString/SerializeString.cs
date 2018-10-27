namespace p03._01.SerializeString
{
    using System;
    using System.Collections.Generic;

    class SerializeString
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine()
                .ToCharArray();

            var dataChars = new Dictionary<char, List<int>>();

            for (int i = 0; i < input.Length; i++)
            {
                char @char = input[i];

                if (!dataChars.ContainsKey(@char))
                {
                    dataChars.Add(@char, new List<int>());
                }

                dataChars[@char].Add(i);
            }

            foreach (var dataChar in dataChars)
            {
                char @char = dataChar.Key;
                List<int> indexes = dataChar.Value;

                Console.WriteLine(
                    $"{@char}:{string.Join("/", indexes)}");
            }
        }
    }
}
