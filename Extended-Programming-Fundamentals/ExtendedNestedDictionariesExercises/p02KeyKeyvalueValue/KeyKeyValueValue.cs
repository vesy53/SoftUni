using System;
using System.Collections.Generic;
using System.Linq;

class KeyKeyValueValue
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();
        string searchKey = Console.ReadLine();
        string searchValue = Console.ReadLine();
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            List<string> inputTokens = Console.ReadLine()
                .Split(new string[] { " => " }, 
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .ToList();

            string key = inputTokens[0];
            List<string> value = inputTokens[1]
                .Split(';')
                .ToList();

            bool isFound = false;
            int index = 0;
            int count = 0;
            
            for (int j = 0; j < searchKey.Length; j++)
            {
                for (int k = index; k < key.Length; k++)
                {
                    if (searchKey[j] == key[k])
                    {
                        count++;
                        index = k;

                        if (count == searchKey.Length)
                        {
                            isFound = true;
                            break;
                        }

                        break;
                    }              
                }
            }

            if (isFound)
            {
                data.Add(key, new List<string>());
            }
            else
            {
                continue;
            }

            for (int j = 0; j < value.Count; j++)
            {
                if (value[j].Contains(searchValue))
                {
                    data[key].Add(value[j]);
                }
            }
        }

        foreach (var itemData in data)
        {
            string key = itemData.Key;
            List<string> value = itemData.Value;

            Console.WriteLine($"{key}:");

            foreach (var itemValue in value)
            {
                Console.WriteLine($"-{itemValue}");
            }
        }
    }
}

