namespace p11._03.PartyFilterModule
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

            List<string> guests = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .ToList();
            string input = Console.ReadLine();

            List<Filter> filters = new List<Filter>();

            while (input.Equals("Print") == false)
            {
                string[] tokens = input
                    .Split(';');

                string command = tokens[0];
                string criteria = tokens[1];
                string parameter = tokens[2];

                Filter currFilter = new Filter(criteria, parameter);

                if (command == "Add filter")
                {
                    filters.Add(currFilter);
                }
                else if (command == "Remove filter")
                {
                    filters
                        .RemoveAll(f => f.Criteria == criteria && 
                                        f.Parameter == parameter);
                }

                input = Console.ReadLine();
            }

            foreach (Filter filter in filters)
            {
                string criteria = filter.Criteria;
                string parameters = filter.Parameter;

                Func<string, bool> function = TakeFilters(criteria, parameters);

                guests = guests
                    .Where(g => (function(g) == false))
                    .ToList();
            }

            print(guests);
        }

        static Func<string, bool> TakeFilters(
            string criteria, 
            string parameters)
        {
            if (criteria == "Starts with")
            {
                return p => p.StartsWith(parameters);
            }
            else if (criteria == "Ends with")
            {
                return p => p.EndsWith(parameters);
            }
            else if (criteria == "Length")
            {
                return p => p.Length == int.Parse(parameters);
            }
            else if (criteria == "Contains")
            {
                return p => p.Contains(parameters);
            }

            return null;
        }
    }

    class Filter
    {
        public Filter(string criteria, string parameters)
        {
            this.Criteria = criteria;
            this.Parameter = parameters;
        }

        public string Criteria { get; set; }

        public string Parameter { get; set; }
    }
}
