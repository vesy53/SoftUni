namespace p04._03.JSONParse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class JSONParse3
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            input = input.Remove(0, 1);
            input = input.Remove(input.Length - 1);

            string[] inputTokens = input
                .Split("{}"
                    .ToCharArray(),
                    StringSplitOptions
                    .RemoveEmptyEntries);

            for (int i = 0; i < inputTokens.Length; i += 2)
            {
                var currentArgs = inputTokens[i]
                    .Split(":\",[]"
                        .ToCharArray(),
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .ToArray();

                string name = currentArgs[1];
                int age = int.Parse(currentArgs[3]);
                List<string> grades = currentArgs.Length > 2 ?
                    currentArgs.Skip(5).ToList() :
                    new List<string>();

                string gradesStr = grades.Any() ? 
                    string.Join(",", grades) : 
                    "None";

                Console.WriteLine($"{name} : {age} -> {gradesStr}");
            }
        }
    }
}
