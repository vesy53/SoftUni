using System.Collections.Generic;

namespace p09._01.TeamworkProjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TeamworkProjects
    {
        static void Main(string[] args)
        {
            int countOfTheTeams = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();
            
            for (int i = 0; i < countOfTheTeams; i++)
            {
                string[] input = Console.ReadLine()
                    .Split('-');

                string creatorName = input[0];
                string teamName = input[1];

                if(teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine(
                        $"Team {teamName} was already created!");
                }
                else if (teams.Any(x => x.CreatorName == creatorName))
                {
                    Console.WriteLine(
                        $"{creatorName} cannot create another team!");
                }
                else if (teams.Any(x => x.CreatorName == creatorName) == false)
                {
                    Team team = new Team();
                    team.TeamName = teamName;
                    team.CreatorName = creatorName;
                    team.Members = new List<string>();
                    
                    teams.Add(team);

                    Console.WriteLine(
                        $"Team {teamName} has been created by {creatorName}!");
                }
            }

            string command = Console.ReadLine();

            while (command.Equals("end of assignment") == false)
            {
                string[] commandTokens = command
                    .Split(new string[] { "->" },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string member = commandTokens[0];
                string teamName = commandTokens[1];

                if(!teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine(
                        $"Team {teamName} does not exist!");
                }
                else if (teams.Any(x => x.CreatorName == member) ||
                        teams.Any(x => x.Members.Contains(member)))
                {
                    Console.WriteLine(
                        $"Member {member} cannot join team {teamName}!");
                    
                }
                else //if there are no members
                {
                    Team existingTeam = teams
                        .Where(x => x.TeamName == teamName)
                        .First();

                    existingTeam.Members.Add(member);
                }

                command = Console.ReadLine();
            }

            var teamsMembers = teams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count())
                .ThenBy(x => x.TeamName)
                .ToList();

            foreach (Team team in teamsMembers)
            {
                string teamName = team.TeamName;
                string creatorName = team.CreatorName;
                List<string> members = team.Members;

                Console.WriteLine($"{teamName}");
                Console.WriteLine($"- {creatorName}");

                foreach (var member in members
                    .OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            var zeroMembers = teams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.TeamName)
                .ToList();

            Console.WriteLine($"Teams to disband:");
           
            foreach (Team item in zeroMembers)
            {
                string teamName = item.TeamName;

                Console.WriteLine($"{teamName}");
            }
        }
    }

    class Team
    {
        public string TeamName { get; set; }

        public string CreatorName { get; set; }

        public List<string> Members { get; set; }
    }
}
