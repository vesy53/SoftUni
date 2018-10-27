using System;
using System.Collections.Generic;

class AMinerTask
{
    static void Main(string[] args)
    {
        Dictionary<string, int> minerResources = new Dictionary<string, int>();
        string commands = Console.ReadLine();

        while (commands.Equals("stop") == false)
        {
            int quantity = int.Parse(Console.ReadLine());

            if (!minerResources.ContainsKey(commands))
            {
                minerResources.Add(commands, 0);
            }

            minerResources[commands] += quantity;

            commands = Console.ReadLine();
        }

        foreach (KeyValuePair<string, int> resurce in minerResources)
        {
            Console.WriteLine($"{resurce.Key} -> {resurce.Value}");
        }
    }
}

