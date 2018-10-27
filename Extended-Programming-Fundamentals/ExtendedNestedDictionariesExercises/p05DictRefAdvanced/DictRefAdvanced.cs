using System;
using System.Collections.Generic;
using System.Linq;

class DictRefAdvanced
{
    static void Main(string[] args)
    {
        var data = new Dictionary<string, List<int>>();
        string[] inputTokens = Console.ReadLine()
            .Split(new string[] { " -> " },
                StringSplitOptions
                .RemoveEmptyEntries);


        while (inputTokens[0] != "end")
        {
            string name = inputTokens[0];

            if (IsName(inputTokens[1]))
            {
                string otherName = inputTokens[1];

                if (data.ContainsKey(otherName))
                {
                    List<int> otherNumbers = data[otherName];

                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, new List<int>());
                    }

                    data[name].Clear();
                    data[name].AddRange(otherNumbers);
                }
            }
            else
            {
                int[] numbers = inputTokens[1]
                    .Split(", "
                    .ToCharArray(),
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (!data.ContainsKey(name))
                {
                    data.Add(name, new List<int>());       
                }

                data[name].AddRange(numbers);
            }

            inputTokens = Console.ReadLine()
                .Split(new string[] { " -> " },
                    StringSplitOptions
                    .RemoveEmptyEntries);
        }

        foreach (var itemData in data)
        {
            string name = itemData.Key;
            List<int> numbers = itemData.Value;

            Console.WriteLine(
                $"{name} === {string.Join(", ", numbers)}");
        }
    }

    static bool IsName(string input)
    {
        foreach (var item in input)
        {
            if (char.IsLetter(item))
            {
                return true;
            }
        }

        return false;
    }
}

