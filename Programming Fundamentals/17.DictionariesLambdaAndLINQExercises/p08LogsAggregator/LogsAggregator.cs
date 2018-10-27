using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

class LogsAggregator
{
    static void Main(string[] args)
    {
        var logsAgreggator = new Dictionary<string, Dictionary<string, int>>();
        var logsSum = new Dictionary<string, int>();
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            string[] inputTokens = Console.ReadLine()
                .Split();

            string ip = inputTokens[0];
            string user = inputTokens[1];
            int duration = int.Parse(inputTokens[2]);

            if (!logsAgreggator.ContainsKey(user))
            {
                logsAgreggator.Add(user, new Dictionary<string, int>());
                logsSum.Add(user, 0);
            }

            if (!logsAgreggator[user].ContainsKey(ip))
            {
                logsAgreggator[user].Add(ip, 0);
            }

            logsAgreggator[user][ip] += duration;
            logsSum[user] += duration;
        }

        foreach (var logData in logsAgreggator
            .OrderBy(x => x.Key))
        {
            string user = logData.Key;
            Dictionary<string, int> data = logData.Value;

            Console.Write($"{user}: {logsSum[user]} [");

            StringBuilder result = new StringBuilder();
            int count = 0;

            foreach (var item in data
                .OrderBy(x => x.Key))
            {
                string ip = item.Key;
                int duration = item.Value;

                if (count != data.Count - 1)
                {
                    result.Append($"{ip}, ");
                }
                else
                {
                    result.Append($"{ip}");
                }

                count++;
            }

            Console.WriteLine(result.ToString() + "]");
        }
    }
}

