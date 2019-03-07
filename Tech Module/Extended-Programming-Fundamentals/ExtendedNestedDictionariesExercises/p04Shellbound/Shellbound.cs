using System;
using System.Collections.Generic;
using System.Linq;

class Shellbound
{
    static void Main(string[] args)
    {
        var data = new Dictionary<string, List<int>>();
        string[] inputTokens = Console.ReadLine()
            .Split();

        while (inputTokens[0].Equals("Aggregate") == false)
        {
            string regionsName = inputTokens[0];
            int shellSize = int.Parse(inputTokens[1]);

            if (!data.ContainsKey(regionsName))
            {
                data.Add(regionsName, new List<int>());
            }

            if (!data[regionsName].Contains(shellSize))
            {
                data[regionsName].Add(shellSize);
            }
            
            inputTokens = Console.ReadLine()
                .Split();
        }

        foreach (var itemData in data)
        {
            string regionsName = itemData.Key;
            List<int> shellSize = itemData.Value;

            int sum = shellSize.Sum();
            int average = (int)shellSize.Average();
            int result = sum - average;

            Console.WriteLine(
                $"{regionsName} -> {string.Join(", ", shellSize)} ({result})");
        }
    }
}

