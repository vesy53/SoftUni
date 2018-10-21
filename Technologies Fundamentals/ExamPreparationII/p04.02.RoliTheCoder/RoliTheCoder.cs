namespace p04._02.RoliTheCoder
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class RoliTheCoder2  
    {
        static void Main(string[] args)
        {
            var dataEvents = new Dictionary<int, Event>();

            string input = Console.ReadLine();

            while (input.Equals("Time for Code") == false)
            {
                string[] tokens = input
                    .Split(new char[] { ' ' },
                        StringSplitOptions
                        .RemoveEmptyEntries);
                int id = int.Parse(tokens[0]);
                string eventName = tokens[1];               

                if (eventName.StartsWith("#") == false)
                {
                    input = Console.ReadLine();
                    continue;
                }

                eventName = eventName.Substring(1);

                if (!dataEvents.ContainsKey(id))
                {
                    List<string> participants = tokens
                    .Skip(2)
                    .ToList();

                    Event currentEvent = new Event(eventName, participants);

                    dataEvents.Add(id, currentEvent);
                }
                else if (dataEvents[id].EventName.Equals(eventName))
                {
                    for (int i = 2; i < tokens.Length; i++)
                    {
                        if (!dataEvents[id].Participants.Contains(tokens[i]))
                        {
                            dataEvents[id].Participants.Add(tokens[i]);
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
                int count = dataEvent.Value.Participants.Distinct().Count();

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

        public Event(
            string eventName, 
            List<string> participants)
        {
            this.EventName = eventName;
            this.Participants = participants;
        }
    }
}
