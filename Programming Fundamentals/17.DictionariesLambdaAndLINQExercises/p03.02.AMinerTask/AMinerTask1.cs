using System;
using System.Collections.Generic;

class AMinerTask1
{
    static void Main(string[] args)
    {
        Dictionary<string, int> minerResources = new Dictionary<string, int>();
        string inputResurce = Console.ReadLine();

        string resource = string.Empty;
        int index = 1;

        while (inputResurce.Equals("stop") == false)
        {
            if (index % 2 != 0)
            {
                if (!minerResources.ContainsKey(inputResurce))
                {
                    minerResources[inputResurce] = 0;
                }

                resource = inputResurce;
            }
            else if (index % 2 == 0)
            {
                minerResources[resource] += int.Parse(inputResurce);
            }

            index++;

            inputResurce = Console.ReadLine();
        }

        foreach (KeyValuePair<string, int> element in minerResources)
        {
            Console.WriteLine($"{element.Key} -> {element.Value}");
        }
    }
}

