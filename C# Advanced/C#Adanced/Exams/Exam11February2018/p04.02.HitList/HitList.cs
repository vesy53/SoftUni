namespace p04._02.HitList
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class HitList
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, SortedDictionary<string, string>>();

            int targetInfoIndex = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input.Equals("end transmissions") == false)
            {
                string[] tokens = input
                   .Split(new char[] { '=', ':', ';' },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string name = tokens[0];

                if (!data.ContainsKey(name))
                {
                    data.Add(name, new SortedDictionary<string, string>());
                }

                for (int i = 1; i < tokens.Length; i += 2)
                {
                    string keyArg = tokens[i];
                    string valueArg = tokens[i + 1];

                    if (!data[name].ContainsKey(keyArg))
                    {
                        data[name].Add(keyArg, string.Empty);
                    }

                    data[name][keyArg] = valueArg;
                }

                input = Console.ReadLine();
            }

            string searchName = Console.ReadLine();

            searchName = searchName.Remove(0, 5);

            Console.WriteLine($"Info on {searchName}:");

            SortedDictionary<string, string> people = data[searchName];

            foreach (var arg in people
                .OrderBy(x => x.Key))
            {
                string key = arg.Key;
                string value = arg.Value;

                Console.WriteLine($"---{key}: {value}");
            }

            int infoIndex = people
                .Sum(x => x.Key.Length + x.Value.Length);

            Console.WriteLine($"Info index: {infoIndex}");

            if (infoIndex >= targetInfoIndex)
            {
                Console.WriteLine("Proceed");
            }
            else if (infoIndex < targetInfoIndex)
            {
                targetInfoIndex -= infoIndex;

                Console.WriteLine(
                    $"Need {targetInfoIndex} more info.");
            }
        }
    }
}