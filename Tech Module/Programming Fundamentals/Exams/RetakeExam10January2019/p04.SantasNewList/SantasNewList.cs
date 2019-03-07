namespace p04.SantasNewList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SantasNewList
    {
        static void Main(string[] args)
        {
            var children = new Dictionary<string, int>();
            var presents = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input.Equals("END") == false)
            {
                string[] tokens = input
                    .Split(new string[] { "->" },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                if (tokens.Length == 3)
                {
                    string name = tokens[0];
                    string gift = tokens[1];
                    int quantity = int.Parse(tokens[2]);

                    if (!children.ContainsKey(name))
                    {
                        children.Add(name, 0);
                    }

                    if (!presents.ContainsKey(gift))
                    {
                        presents.Add(gift, 0);
                    }

                    children[name] += quantity;
                    presents[gift] += quantity;
                }
                else
                {
                    string name = tokens[1];

                    if (children.ContainsKey(name))
                    {
                        children.Remove(name);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Children:");

            foreach (var child in children
                .OrderByDescending(c => c.Value)
                .ThenBy(c => c.Key))
            {
                string name = child.Key;
                int quantity = child.Value;

                Console.WriteLine($"{name} -> {quantity}");
            }

            Console.WriteLine("Presents:");

            foreach (var element in presents)
            {
                string gift = element.Key;
                int quantty = element.Value;

                Console.WriteLine($"{gift} -> {quantty}");
            }
        }
    }
}
