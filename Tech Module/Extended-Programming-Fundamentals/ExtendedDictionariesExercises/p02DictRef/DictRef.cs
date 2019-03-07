using System;
using System.Collections.Generic;

class DictRef
{
    static void Main(string[] args)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        string[] inputValues = Console.ReadLine()
            .Split(new char[] { ' ', '=' }
                , StringSplitOptions
                .RemoveEmptyEntries);

        while (inputValues[0] != "end")
        {
            string name = inputValues[0];
            string value = inputValues[1];

            int numberValue;

            if (int.TryParse(value, out numberValue))
            {
                dict[name] = numberValue;
            }
            else
            {
                if (dict.ContainsKey(value))
                {
                    dict[name] = dict[value];
                }
            }

            inputValues = Console.ReadLine()
                .Split(new char[] { ' ', '=' }
                    , StringSplitOptions
                    .RemoveEmptyEntries);
        }

        foreach (KeyValuePair<string, int> element in dict)
        {
            Console.WriteLine($"{element.Key} === {element.Value}");
        }
    }
}

