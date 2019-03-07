using System;
using System.Linq;
using System.Collections.Generic;

class LINQuistics
{
    static void Main(string[] args)
    {
        var data = new Dictionary<string, HashSet<string>>();

        string input = Console.ReadLine();

        while (input.Equals("exit") == false)
        {
            string[] inputTokens = input
                .Split(new string[] { ".", "()" },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            if (inputTokens.Length == 1)
            {
                string command = inputTokens[0];

                int number;
                bool isDigit = int.TryParse(command, out number);

                if (isDigit)
                {
                    if (data.Count > 0)
                    {
                        var bigCollection = data
                            .OrderByDescending(x => x.Value.Count)
                            .First();

                        var printMethods = bigCollection
                            .Value
                            .OrderBy(x => x.Length)
                            .Take(number);

                        foreach (var printMethod in printMethods)
                        {
                            Console.WriteLine($"* {printMethod}");
                        }
                    }                  
                }
                else
                {
                    //Ако колекцията вече съществува, трябва да добавите новите
                    //методи към нея. Дублираните методи трябва да бъдат премахнати
                    if (data.ContainsKey(inputTokens[0]))
                    {
                        var methodNames = data[inputTokens[0]]
                            .OrderByDescending(x => x.Length)
                            .ThenByDescending(x => x.Distinct().Count());

                        foreach (var methodName in methodNames)
                        {
                            Console.WriteLine($"* {methodName}");
                        }
                    }

                }
            }
            else if(inputTokens.Length > 1)
            {
                string collection = inputTokens[0];

                if (!data.ContainsKey(collection))
                {
                    data.Add(collection, new HashSet<string>());
                }

                for (int i = 1; i < inputTokens.Length; i++)
                {
                    data[collection].Add(inputTokens[i]);
                }
            }

            input = Console.ReadLine();
        }

        string[] commands = Console.ReadLine()
            .Split();

        string method = commands[0];
        string selection = commands[1];

        if (selection == "collection")
        {
            var result = data
                .Where(x => x.Value.Contains(method))
                .OrderByDescending(x => x.Value.Count())
                .ThenByDescending(x => x.Value.Min(y => y.Length));

            foreach (var item in result)
            {
                string collection = item.Key;

                Console.WriteLine($"{collection}");
            }
        }
        else if (selection == "all")
        {
            var result = data
                .Where(x => x.Value.Contains(method))
                .OrderByDescending(x => x.Value.Count())
                .ThenByDescending(x => x.Value.Min(y => y.Length));

            foreach (var item in result)
            {
                string collection = item.Key;
                HashSet<string> methods = item.Value;

                Console.WriteLine($"{collection}");

                foreach (var itemMethod in methods
                    .OrderByDescending(x => x.Length))
                {
                    Console.WriteLine($"* {itemMethod}");
                }
            }
        }
    }
}

