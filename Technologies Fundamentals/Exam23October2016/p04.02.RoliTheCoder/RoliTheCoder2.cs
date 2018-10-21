namespace p04._02.RoliTheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class RoliTheCoder2
    {
        static void Main(string[] args)
        {
            var dataEvents = new Dictionary<int, Event>();

            string input = Console.ReadLine();

            while (input.Equals("Time for Code") == false)
            {
                string[] inputTokens = input
                    .Split(new char[] { ' ' },
                        StringSplitOptions
                        .RemoveEmptyEntries);
                int id = int.Parse(inputTokens[0]);
                string eventName = inputTokens[1];
                List<string> participants = inputTokens
                    .Skip(2)
                    .ToList();

                if (eventName.StartsWith("#"))
                {
                    eventName = eventName.Substring(1);

                    if (!dataEvents.ContainsKey(id))
                    {
                        dataEvents.Add(id, new Event(eventName, participants));
                    }
                    else
                    {
                        if (dataEvents[id].EventName != eventName)
                        {
                            input = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            dataEvents[id].Participants.AddRange(participants);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var dataEvent in dataEvents
                .OrderByDescending(x => x.Value.Participants.Distinct().Count())
                .ThenBy(x => x.Value.EventName))
            {
                string eventName = dataEvent.Value.EventName;
                List<string> participants = dataEvent.Value.Participants;
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

    class Event
    {
        public string EventName { get; set; }

        public List<string> Participants { get; set; }

        public Event(string eventName, List<string> participants)
        {
            this.EventName = eventName;
            this.Participants = participants;
        }
    }
}
