using System;
using System.Collections.Generic;
using System.Linq;

class DictRef1
{
    static void Main(string[] args)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        List<string> inputValues = Console.ReadLine()
            .Split(new char[] { ' ', '=' }
                , StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();

        while (inputValues[0] != "end")
        {
            string name = inputValues.First();
            string value = inputValues.Last();

            int numberValue = 0;
            bool isDigit = int.TryParse(value, out numberValue);

            if (isDigit)
            {
                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, 0);
                }

                dict[name] = numberValue;
            }
            else
            {
                if (dict.ContainsKey(value))
                {
                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, 0);
                    }

                    dict[name] = dict[value];
                }
            }

            inputValues = Console.ReadLine()
            .Split(new char[] { ' ', '=' }
                , StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();
        }

        foreach (KeyValuePair<string, int> item in dict)
        {
            Console.WriteLine($"{item.Key} === {item.Value}");
        }
    }
}

