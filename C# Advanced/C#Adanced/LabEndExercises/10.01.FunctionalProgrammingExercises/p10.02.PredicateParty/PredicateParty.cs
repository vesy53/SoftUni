namespace p10._02.PredicateParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PredicateParty
    {
        static void Main(string[] args)
        {
            Predicate<string> predicate;
            Action<List<string>> print = names => Console.WriteLine(
                        $"{string.Join(", ", names)} are going to the party!");

            List<string> guests = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .ToList();
            string input = Console.ReadLine();

            while (input.Equals("Party!") == false)
            {
                string[] tokens = input
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string command = tokens[0];
                string predicateName = tokens[1];
                string value = tokens[2];

                predicate = TakePredicate(predicateName, value);

                if (command == "Remove")
                {
                    guests.RemoveAll(predicate);
                }
                else if (command == "Double")
                {
                    List<string> newGuest = guests.FindAll(predicate);

                    foreach (var guest in newGuest)
                    {
                        int indexCurrGuest = guests.IndexOf(guest);

                        guests.Insert(indexCurrGuest + 1, guest);
                    }
                }

                input = Console.ReadLine();
            }

            if (guests.Count() == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                print(guests);
            }
        }

        static Predicate<string> TakePredicate(
            string predicateName,
            string value)
        {
            if (predicateName == "StartsWith")
            {
                return p => p.StartsWith(value);
            }
            else if (predicateName == "EndsWith")
            {
                return p => p.EndsWith(value);
            }
            else if (predicateName == "Length")
            {
                return p => p.Length == int.Parse(value);
            }

            return null;
        }
    }
}