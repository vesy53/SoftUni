namespace p10._04.PredicateParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PredicateParty
    {
        static void Main(string[] args)
        {
            Func<List<string>, string> print = p => p.Count > 0 ?
                            ($"{string.Join(", ", p)} are going to the party!") :
                            ("Nobody is going to the party!");

            List<string> guests = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .ToList();
            string input = Console.ReadLine();

            while (input.Equals("Party!") == false)
            {
                string[] inputArgs = input
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string command = inputArgs[0];
                string criteria = inputArgs[1];
                string value = inputArgs[2];

                if (criteria == "StartsWith")
                {
                    guests = TakeTheGuests(command, guests, g => g.StartsWith(value));
                }
                else if (criteria == "EndsWith")
                {
                    guests = TakeTheGuests(command, guests, g => g.EndsWith(value));
                }
                else if (criteria == "Length")
                {
                    guests = TakeTheGuests(command, guests, g => g.Length == int.Parse(value));
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(print(guests));
        }

        static List<string> TakeTheGuests(
            string command,
            List<string> guests,
            Func<string, bool> condition)
        {
            if (command == "Remove")
            {
                guests = guests.Where(g => !condition(g)).ToList();
            }
            else if (command == "Double")
            {
                for (int i = 0; i < guests.Count; i++)
                {
                    if (condition(guests[i]))
                    {
                        guests.Insert(i, guests[i]);
                        i++;
                    }
                }
            }

            return guests;
        }
    }
}