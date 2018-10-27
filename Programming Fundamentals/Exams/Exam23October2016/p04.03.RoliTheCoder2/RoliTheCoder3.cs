namespace p04._03.RoliTheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class RoliTheCoder3
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Event> events = new List<Event>();

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

                    if (!events.Any(x => x.Id == id))
                    {
                        Event currEvent = new Event
                        (
                            id,
                            eventName,
                            new SortedSet<string>()
                        );

                        events.Add(currEvent);
                    }

                    if (events.First(x => x.Id == id).EventName == eventName)
                    {
                        SortedSet<string> currentParticipants = events.First(x => x.Id == id).Participants;
                        participants.ForEach(x => currentParticipants.Add(x));
                        //or
                        //foreach (var participant in participants)
                        //{
                        //    currentParticipants.Add(participant);
                        //}

                        events.First(x => x.Id == id).Participants = currentParticipants;
                    }
                }

                input = Console.ReadLine();
            }

            events = events
               .OrderByDescending(x => x.Participants.Count())
               .ThenBy(x => x.EventName)
               .ToList();

            foreach (var currentEvent in events)
            {
                string eventName = currentEvent.EventName;
                SortedSet<string> participants = currentEvent.Participants;
                int count = currentEvent.Participants.Count();

                Console.WriteLine($"{eventName} - {count}");

                foreach (var participant in participants)
                {
                    Console.WriteLine($"{participant}");
                }
            }
        }
    }

    class Event
    {
        public int Id { get; set; }

        public string EventName { get; set; }

        public SortedSet<string> Participants { get; set; } //Имаме много елементи и искаме да ги съхраняваме в сортиран ред и да премахнем всички дубликати от структурата на данните.

        public Event(int id, string eventName, SortedSet<string> participants)
        {
            this.Id = id;
            this.EventName = eventName;
            this.Participants = participants;
        }
    }
}
