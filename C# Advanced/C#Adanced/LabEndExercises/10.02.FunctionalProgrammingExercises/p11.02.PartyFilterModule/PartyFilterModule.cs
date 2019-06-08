namespace p11._02.PartyFilterModule
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PartyFilterModule
    {
        static void Main(string[] args)
        {
            Action<List<string>> print = p =>
                        Console.WriteLine(string.Join(" ", p));

            var data = new Dictionary<string, List<string>>();

            List<string> guests = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .ToList();
            string input = Console.ReadLine();

            while (input.Equals("Print") == false)
            {
                string[] tokens = input
                    .Split(';');

                string command = tokens[0];
                string criteria = tokens[1];
                string parameter = tokens[2];

                if (command == "Add filter")
                {
                    if (!data.ContainsKey(criteria))
                    {
                        data.Add(criteria, new List<string>());
                    }

                    data[criteria].Add(parameter);
                }
                else if (command == "Remove filter")
                {
                    data[criteria].Remove(parameter);
                }

                input = Console.ReadLine();
            }

            foreach (var itemData in data)
            {
                string criteria = itemData.Key;
                List<string> parameters = itemData.Value;

                foreach (string param in parameters)
                {
                    Func<string, bool> function = TakeFilters(criteria, param);

                    guests = guests
                        .Where(g => (function(g) == false))
                        .ToList();
                }
            }

            print(guests);
        }

        static Func<string, bool> TakeFilters(
            string criteria, 
            string param)
        {
            if (criteria == "Starts with")
            {
                return p => p.StartsWith(param);
            }
            else if (criteria == "Ends with")
            {
                return p => p.EndsWith(param);
            }
            else if (criteria == "Length")
            {
                return p => p.Length == int.Parse(param);
            }
            else if (criteria == "Contains")
            {
                return p => p.Contains(param);
            }

            return null;
        }
    }
}
