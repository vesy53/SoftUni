namespace p08._01.Ranking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Ranking
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            var submissions = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input.Equals("end of contests") == false)
            {
                string[] tokens = input
                    .Split(":");

                string contest = tokens[0];
                string password = tokens[1];

                contests[contest] = password;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input.Equals("end of submissions") == false)
            {
                string[] tokens = input
                    .Split("=>");

                string contest = tokens[0];
                string password = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);

                if (contests.ContainsKey(contest) &&
                    contests[contest] == password)
                {
                    if (!submissions.ContainsKey(username))
                    {
                        submissions.Add(username, new Dictionary<string, int>());
                    }

                    if (!submissions[username].ContainsKey(contest))
                    {
                        submissions[username].Add(contest, 0);
                    }

                    if (submissions[username][contest] < points)
                    {
                        submissions[username][contest] = points;
                    }
                }

                input = Console.ReadLine();
            }

            var bestCandidate = submissions
                .OrderByDescending(x => x.Value.Values.Sum())
                .Take(1)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var data in bestCandidate)
            {
                string user = data.Key;
                Dictionary<string, int> submissionsArgs = data.Value;

                int totalPoints = submissionsArgs.Values.Sum();

                Console.WriteLine(
                    $"Best candidate is {user} with total {totalPoints} points.");
            }

            Console.WriteLine("Ranking:");


            foreach (var data in submissions
                .OrderBy(d => d.Key))
            {
                string name = data.Key;
                Dictionary<string, int> contestsArgs = data.Value;

                Console.WriteLine($"{name}");

                foreach (var contestsArg in contestsArgs
                    .OrderByDescending(c => c.Value))
                {
                    string contest = contestsArg.Key;
                    int point = contestsArg.Value;

                    Console.WriteLine($"#  {contest} -> {point}");
                }
            }
        }
    }
}
