using System;
using System.Collections.Generic;
using System.Linq;

class DictRefAdvanced1
{
    static void Main(string[] args)
    {
        Dictionary<string, List<int>> data = new Dictionary<string, List<int>>();
        string[] inputTokens = Console.ReadLine()
            .Split(new string[] { " -> " },
                StringSplitOptions
                .RemoveEmptyEntries)
            .ToArray();

        while (inputTokens[0].Equals("end") == false)
        {
            string name = inputTokens[0];
            string[] numbers = inputTokens[1]
                .Split(new string[] { ",", " " },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                 .ToArray();

            int numb = 0; 
            bool isDigit = int.TryParse(numbers[0], out numb);

            if (isDigit)
            {

                if (!data.ContainsKey(name))
                {
                    data.Add(name, new List<int>());
                }

                data[name].AddRange(numbers.Select(int.Parse));
                
                // another method per convert List<string> to List<int>
                //List<int> otherNumbers = numbers.Select(n => int.Parse(n)).ToList();
                //data[name].AddRange(otherNumbers);
            }
            else  // is letter
            {
                string valueName = inputTokens[1];

                foreach (var item in data)
                {
                    if (item.Key == valueName)
                    {
                        data[name] = new List<int>(data[item.Key]);   
                        break;
                    }
                }
            }

            inputTokens = Console.ReadLine()
            .Split(new string[] { " -> " },
                StringSplitOptions
                .RemoveEmptyEntries)
            .ToArray();
        }

        foreach (var itemData in data)
        {
            string name = itemData.Key;
            List<int> numbers = itemData.Value;

            Console.WriteLine(
                $"{name} === {string.Join(", ", numbers)}");
        }
    }
}

