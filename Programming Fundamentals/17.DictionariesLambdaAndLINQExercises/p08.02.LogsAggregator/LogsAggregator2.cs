using System;
using System.Collections.Generic;
using System.Linq;

class LogsAggregator2
{
    static void Main(string[] args)
    {
        var logsAggregator = new SortedDictionary<string, SortedDictionary<string, int>>();

        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            string[] inputTokens = Console.ReadLine()
                .Split(' ');

            string ip = inputTokens[0];
            string user = inputTokens[1];
            int duration = int.Parse(inputTokens[2]);

            if (!logsAggregator.ContainsKey(user))
            {
                logsAggregator.Add(user, new SortedDictionary<string, int>());
            }

            if (!logsAggregator[user].ContainsKey(ip))
            {
                logsAggregator[user].Add(ip, 0);
            }

            logsAggregator[user][ip] += duration;
        }

        foreach (var log in logsAggregator)
        {
            string user = log.Key;
            int sumDurations = log.Value.Values.Sum();
            string ip = string.Join(", ", log.Value.Keys);

            Console.WriteLine(
                $"{user}: {sumDurations} [{ip}]");
        }
    }
}

