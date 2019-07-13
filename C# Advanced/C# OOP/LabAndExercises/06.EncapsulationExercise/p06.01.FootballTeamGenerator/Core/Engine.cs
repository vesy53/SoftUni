namespace p06._01.FootballTeamGenerator.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using IO.Contracts;
    using p06._01.FootballTeamGenerator.Models;
    using p06._01.FootballTeamGenerator.Validations;

    public class Engine
    {
        private IReader reader;
        private IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            List<Team> teams = new List<Team>();

            string input = reader.ConsoleReadLine();

            while (input.Equals("END") == false)
            {
                try
                {
                    string[] tokens = input
                    .Split(';');

                    string command = tokens[0].ToLower();

                    if (command == "team")
                    {
                        string teamName = tokens[1];

                        Team team = new Team(teamName);

                        teams.Add(team);
                    }
                    else if (command == "add")
                    {
                        AddPlayerToTheTeam(teams, tokens);
                    }
                    else if (command == "remove")
                    {
                        RemovePlayerFromTheTeam(teams, tokens);
                    }
                    else if (command == "rating")
                    {
                        PrintTheTeamReating(teams, tokens);
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

                input = reader.ConsoleReadLine();
            }  
        }

        private void PrintTheTeamReating(
            List<Team> teams, 
            string[] tokens)
        {
            string teamName = tokens[1];

            Team team = teams
                .FirstOrDefault(t => t.Name == teamName);

            if (team == null)
            {
                Validation.ValidateMissingTeam(teamName);
            }
            else
            {
                writer.ConsoleWriteLine(team.ToString());
            }
        }

        private void RemovePlayerFromTheTeam(
            List<Team> teams, 
            string[] tokens)
        {
            string teamName = tokens[1];
            string playerName = tokens[2];

            Team team = teams
                .FirstOrDefault(t => t.Name == teamName);

            if (team != null)
            {
                team.RemovePlayer(playerName);
            }
        }

        private void AddPlayerToTheTeam(
            List<Team> teams, 
            string[] tokens)
        {
            string teamName = tokens[1];
            string playerName = tokens[2];
            int endurance = int.Parse(tokens[3]);
            int sprint = int.Parse(tokens[4]);
            int dribble = int.Parse(tokens[5]);
            int passing = int.Parse(tokens[6]);
            int shooting = int.Parse(tokens[7]);

            bool isExistTeam = teams
                .Any(t => t.Name == teamName);

            if (isExistTeam)
            {
                Stat stat = new Stat(
                    endurance,
                    sprint,
                    dribble,
                    passing,
                    shooting);

                Player player = new Player(playerName, stat);

                teams
                    .FirstOrDefault(t => t.Name == teamName)
                    .AddPlayer(player);
            }
            else
            {
                Validation.ValidateMissingTeam(teamName);
            }
        }
    }
}
