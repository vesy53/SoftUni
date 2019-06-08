namespace p10._03.PredicateParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PredicateParty
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .ToList();
            string input = Console.ReadLine();

            Func<List<string>, string, string, List<string>> funcRemove = (guest, crit, val) =>
            {
                if (crit == "StartsWith")
                {
                    guest.RemoveAll(g => g.StartsWith(val));
                }
                else if (crit == "EndsWith")
                {
                    guest.RemoveAll(g => g.EndsWith(val));
                }
                else if (crit == "Length")
                {
                    guest.RemoveAll(g => g.Length <= int.Parse(val));
                }

                return guest;
            };

            Func<List<string>, string, string, List<string>> funcDouble = (guest, crit, val) =>
            {
                if (crit == "StartsWith")
                {
                    for (int i = 0; i < guest.Count; i++)
                    {
                        if (guest[i].StartsWith(val))
                        {
                            guest.Insert(i, guest[i]);
                            i++;
                        }
                    }
                }
                else if (crit == "EndsWith")
                {
                    for (int i = 0; i < guest.Count; i++)
                    {
                        if (guest[i].EndsWith(val))
                        {
                            guest.Insert(i, guest[i]);
                            i++;
                        }
                    }
                }
                else if (crit == "Length")
                {
                    for (int i = 0; i < guest.Count; i++)
                    {
                        if (guest[i].Length <= int.Parse(val))
                        {
                            guest.Insert(i, guest[i]);
                            i++;
                        }
                    }
                }

                return guest;
            };

            Func<List<string>, string> print = p => p.Count > 0 ?
                            ($"{string.Join(", ", p)} are going to the party!") :
                            ("Nobody is going to the party!");

            while (input.Equals("Party!") == false)
            {
                string[] inputTokens = input
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string command = inputTokens[0];
                string criteria = inputTokens[1];
                string value = inputTokens[2];

                if (command == "Remove")
                {
                    guests = funcRemove(guests, criteria, value);
                }
                else if (command == "Double")
                {
                    guests = funcDouble(guests, criteria, value);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(print(guests));
        }
    }
}