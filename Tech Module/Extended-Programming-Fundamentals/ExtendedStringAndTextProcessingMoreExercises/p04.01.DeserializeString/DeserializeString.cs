namespace p04._01.DeserializeString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class DeserializeString
    {
        static void Main(string[] args)
        {
            var lettersIndices = new SortedDictionary<int, char>();

            string input = Console.ReadLine();

            while (input.Equals("end") == false)
            {
                string[] tokens = input
                    .Split(':');

                char @char = tokens[0][0];
                int[] indices = tokens[1]
                    .Split('/')
                    .Select(int.Parse)
                    .ToArray();

                foreach (int index in indices)
                {
                    lettersIndices[index] = @char;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(lettersIndices.Values.ToArray());
        }
    }
}
