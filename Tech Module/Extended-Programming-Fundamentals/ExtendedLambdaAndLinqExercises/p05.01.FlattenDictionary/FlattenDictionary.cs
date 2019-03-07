using System;
using System.Collections.Generic;
using System.Linq;

class FlattenDictionary
{
    static void Main(string[] args)
    {
        var data = new Dictionary<string, Dictionary<string, string>>();
        var flattenData = new Dictionary<string, List<string>>();

        string input = Console.ReadLine();

        while (input.Equals("end") == false)
        {
            string[] inputTokens = input
                .Split();

            if (inputTokens[0] == "flatten")
            {
                string keyFlatten = inputTokens[1];

                foreach (var itemData in data)
                {
                    string key = itemData.Key;
                    Dictionary<string, string> innerRecords = itemData.Value;

                    if (keyFlatten == key)
                    {
                        foreach (var innerRecord in innerRecords)
                        {
                            string concatedValue = innerRecord.Key + innerRecord.Value;

                            if (!flattenData.ContainsKey(key))
                            {
                                flattenData.Add(key, new List<string>());
                            }

                            flattenData[key].Add(concatedValue);
                        }
                    }
                }
                //зануляваме value-то на data
                data[keyFlatten] = new Dictionary<string, string>();
            }
            else
            {
                string key = inputTokens[0];
                string innerKey = inputTokens[1];
                string innerValue = inputTokens[2];

                if (!data.ContainsKey(key))
                {
                    data.Add(key, new Dictionary<string, string>());
                }

                if (!data[key].ContainsKey(innerKey))
                {
                    data[key].Add(innerKey, string.Empty);
                }

                data[key][innerKey] = innerValue;
            }

            input = Console.ReadLine();
        }


        foreach (var itemData in data
            .OrderByDescending(x => x.Key.Length))
        {
            string key = itemData.Key;
            Dictionary<string, string> innersData = itemData.Value;
            int counter = 1;

            Console.WriteLine($"{key}");

            foreach (var innerData in innersData
                .OrderBy(x => x.Key.Length))
            {
                string innerKey = innerData.Key;
                string innerValue = innerData.Value;

                Console.WriteLine(
                    $"{counter}. {innerKey} - {innerValue}");

                counter++;
            }

            if (flattenData.ContainsKey(key))
            {
                foreach (var flattenedValue in flattenData[key])
                {
                    Console.WriteLine($"{counter}. {flattenedValue}");

                    counter++;
                }
            }
        }
    }
}

