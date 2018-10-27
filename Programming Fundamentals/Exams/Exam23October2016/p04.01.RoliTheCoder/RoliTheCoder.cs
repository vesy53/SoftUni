namespace p04._01.RoliTheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class RoliTheCoder
    {
        static void Main(string[] args)
        {
            var dataId = new Dictionary<int, string>();
            var dataEvent = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input.Equals("Time for Code") == false)
            {
                string[] tokens = input
                    .Split(new char[] { ' ' },
                        StringSplitOptions
                        .RemoveEmptyEntries);
                int id = int.Parse(tokens[0]);
                string eventName = tokens[1];
                List<string> participants = tokens
                    .Skip(2)
                    .ToList();

                if (eventName.StartsWith("#"))
                {
                    eventName = eventName.Substring(1);

                    if (!dataId.ContainsKey(id))
                    {
                        dataId.Add(id, string.Empty);
                    }
                    else
                    {
                        if (dataId[id] != eventName)
                        {
                            input = Console.ReadLine();
                            continue;
                        }
                    }

                    dataId[id] = eventName;

                    if (!dataEvent.ContainsKey(eventName))
                    {
                        dataEvent.Add(eventName, new List<string>());
                    }

                    dataEvent[eventName].AddRange(participants);
                }

                input = Console.ReadLine();
            }

            foreach (var item in dataEvent
                .OrderByDescending(x => x.Value.Distinct().Count())
                .ThenBy(x => x.Key))
            {
                string eventName = item.Key;
                List<string> participants = item.Value;
                int count = participants.Distinct().Count();

                Console.WriteLine($"{eventName} - {count}");

                foreach (var participant in participants
                    .Distinct()
                    .OrderBy(x => x))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}
