namespace p02._02.SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SoftUniKaraoke2
    {
        static void Main(string[] args)
        {
            string[] participantsNames = Console.ReadLine()
                .Split(new string[] { ", " },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            string[] songs = Console.ReadLine()
                .Split(new string[] { ", " },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            string input = Console.ReadLine();

            List<Participant> participants = new List<Participant>();

            foreach (var participantName in participantsNames)
            {
                if (!participants.Any(x => x.Name == participantName))
                {
                    var currentParticipant = new Participant(participantName, new HashSet<string>());
                    participants.Add(currentParticipant);
                }
            }

            while (input.Equals("dawn") == false)
            {
                string[] tokens = input
                    .Split(new string[] { ", " },
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .ToArray();

                string name = tokens[0];
                string song = tokens[1];
                string award = tokens[2];

                if (participantsNames.Contains(name) && songs.Contains(song))
                {
                    var currentParicipants = participants.First(x => x.Name == name);
                    currentParicipants.Awards.Add(award);
                }

                input = Console.ReadLine();
            }

            participants = participants
                .Where(x => x.Awards.Count > 0)
                .OrderByDescending(x => x.Awards.Count())
                .ThenBy(x => x.Name)
                .ToList();
            bool hasPerformance = false;

            foreach (var participant in participants)
            {
                Console.WriteLine($"{participant.Name}: {participant.Awards.Count()} awards");

                var currentAwards = participant.Awards.OrderBy(x => x);

                foreach (var award in currentAwards)
                {
                    Console.WriteLine($"--{award}");
                    hasPerformance = true;
                }
            }

            if (!hasPerformance)
            {
                Console.WriteLine("No awards");
            }
        }
    }

    class Participant
    {
        public string Name { get; set; }
    
        public HashSet<string> Awards { get; set; }

        public Participant(string name, HashSet<string> awards)
        {
            this.Name = name;
            this.Awards = awards;
        }   
    }
}
