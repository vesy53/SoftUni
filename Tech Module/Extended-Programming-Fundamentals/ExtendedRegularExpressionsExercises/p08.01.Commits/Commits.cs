namespace p08._01.Commits
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Commits
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex
            (
                @"^https:\/\/github\.com\/(?<user>[A-Za-z0-9-]+)\/(?<repo>[A-Za-z-_]+)\/commit\/(?<hash>[A-Fa-f0-9]{40}),(?<message>[^\n]+),(?<additions>[0-9]+),(?<deletions>[0-9]+)$"
            );

            var data = new SortedDictionary<string, SortedDictionary<string, List<Commit>>>();

            string input = Console.ReadLine();

            while (input.Equals("git push") == false)
            {
                if (pattern.IsMatch(input))
                {
                    Match urlMatch = pattern.Match(input);

                    string username = urlMatch.Groups["user"].Value;
                    string repo = urlMatch.Groups["repo"].Value;
                    string hash = urlMatch.Groups["hash"].Value;
                    string message = urlMatch.Groups["message"].Value;
                    int additions = int.Parse(urlMatch.Groups["additions"].Value);
                    int delitions = int.Parse(urlMatch.Groups["deletions"].Value);

                    Commit newCommit = new Commit
                    (
                        hash, 
                        message, 
                        additions, 
                        delitions
                    );

                    if (!data.ContainsKey(username))
                    {
                        data.Add(username, new SortedDictionary<string, List<Commit>>());
                    }

                    if (!data[username].ContainsKey(repo))
                    {
                        data[username].Add(repo, new List<Commit>());
                    }

                    data[username][repo].Add(newCommit);
                }

                input = Console.ReadLine();
            }

            foreach (var itemData in data)
            {
                string username = itemData.Key;
                SortedDictionary<string, List<Commit>> repos = itemData.Value;

                Console.WriteLine($"{username}:");

                foreach (var itemRepos in repos)
                {
                    string repo = itemRepos.Key;
                    List<Commit> commit = itemRepos.Value;
                    
                    Console.WriteLine($"  {repo}:");

                    foreach (var item in commit)
                    {
                        string hash = item.Hash;
                        string message = item.Message;
                        int additions = item.Additions;
                        int delitions = item.Delitions;

                        Console.WriteLine(
                            $"    commit {hash}: {message} ({additions} additions, {delitions} deletions)");
                    }

                    int totalAdditions = commit.Sum(x => x.Additions);
                    int totalDelitions = commit.Sum(x => x.Delitions);

                    Console.WriteLine(
                        $"    Total: {totalAdditions} additions, {totalDelitions} deletions");
                }
            }
        }
    }

    class Commit
    {
        public string Hash { get; set; }
        public string Message { get; set; }
        public int Additions { get; set; }
        public int Delitions { get; set; }

        public Commit(
            string hash,
            string message,
            int additions, 
            int delitions)
        {
            this.Hash = hash;
            this.Message = message;
            this.Additions = additions;
            this.Delitions = delitions;
        }
    }
}
