namespace p04._01.HitList
{
    using System;
    using System.Collections.Generic;

    class HitList
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, SortedDictionary<string, string>>();

            int infoIndex = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input.Equals("end transmissions") == false)
            {
                string[] tokens = input
                    .Split('=');

                string name = tokens[0];
                string[] arguments = tokens[1]
                    .Split(';');

                for (int i = 0; i < arguments.Length; i++)
                {
                    string[] currArg = arguments[i]
                        .Split(':');

                    string keyArg = currArg[0];
                    string valueArg = currArg[1];

                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, new SortedDictionary<string, string>());
                    }

                    if (!data[name].ContainsKey(keyArg))
                    {
                        data[name].Add(keyArg, string.Empty);
                    }

                    data[name][keyArg] = valueArg;
                }

                input = Console.ReadLine();
            }

            string[] command = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries);

            string searchName = command[1];

            if (data.ContainsKey(searchName))
            {
                int length = 0;

                Console.WriteLine($"Info on {searchName}:");

                foreach (KeyValuePair<string, string> itemData in data[searchName])
                {
                    string key = itemData.Key;
                    string value = itemData.Value;

                    length += key.Length + value.Length;

                    Console.WriteLine($"---{key}: {value}");
                }

                Console.WriteLine($"Info index: {length}");

                if (length >= infoIndex)
                {
                    Console.WriteLine("Proceed");
                }
                else
                {
                    infoIndex -= length;

                    Console.WriteLine($"Need {infoIndex} more info.");
                }
            }
        }
    }
}