using System;
using System.Collections.Generic;
using System.Linq;

class Shellbound2
{
    static void Main(string[] args)
    {
        var data = new Dictionary<string, HashSet<int>>();
        string[] inputTokens = Console.ReadLine()
            .Split();

        while (inputTokens[0].Equals("Aggregate") == false)
        {
            string regionsName = inputTokens[0];
            int shellSize = int.Parse(inputTokens[1]);

            if (!data.ContainsKey(regionsName))
            {
                data.Add(regionsName, new HashSet<int>());
            }

            data[regionsName].Add(shellSize);

            inputTokens = Console.ReadLine()
                .Split();
        }

        foreach (var itemData in data)
        {
            string regionsName = itemData.Key;
            HashSet<int> shellSize = itemData.Value;

            int sum = shellSize.Sum();
            int countShells = shellSize.Count; 
            int result = SumGiantShell(sum, countShells);

            Console.WriteLine(
                $"{regionsName} -> {string.Join(", ", shellSize)} ({result})");
        }
    }

    static int SumGiantShell(int sum, int countShells)
    {
        int result = sum - (sum / countShells);

        return result;
    }
}

