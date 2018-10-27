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
            var dataEvents = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input.Equals("Time for Code") == false)
            {
                string[] tokens = input
                    .Split(new char[] { ' ' },
                        StringSplitOptions
                        .RemoveEmptyEntries);
                int id = int.Parse(tokens[0]);              
                string eventName = tokens[1];
                List<string> participants = new List<string>();
                
                if (!eventName.StartsWith("#"))
                {
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    eventName = eventName
                        .Replace("#", string.Empty)
                        .Trim();
                }

                if (!dataId.ContainsKey(id))
                {
                    dataId.Add(id, eventName);
                    dataEvents.Add(eventName, new List<string>());

                    for (int i = 2; i < tokens.Length; i++)
                    {
                        if (!dataEvents[eventName].Contains(tokens[i]))
                        {
                            dataEvents[eventName].Add(tokens[i]);
                        }
                    }
                }
                else if (dataId[id] == eventName)
                {
                    for (int i = 2; i < tokens.Length; i++)
                    {
                        if (!dataEvents[eventName].Contains(tokens[i]))
                        {
                            dataEvents[eventName].Add(tokens[i]);
                        }
                    }
                }           

                input = Console.ReadLine();
            }

            foreach (var dataEvent in dataEvents
                .OrderByDescending(x => x.Value.Distinct().Count())
                .ThenBy(x => x.Key))
            {
                string eventName = dataEvent.Key;
                List<string> participants = dataEvent.Value;
                int count = dataEvent.Value.Count();

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
