using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class UserLogs1
{
    static void Main(string[] args)
    {
        var usersParameters = new Dictionary<string, Dictionary<string, int>>();
        string input = Console.ReadLine();

        while (input != "end")
        {
            string[] inputTokens = input
                .Split(new char[] { '=', ' ' },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            string ip = inputTokens[1];
            string userName = inputTokens[5];

            if (!usersParameters.ContainsKey(userName))
            {
                usersParameters.Add(userName, new Dictionary<string, int>());
            }

            if (!usersParameters[userName].ContainsKey(ip))
            {
                usersParameters[userName].Add(ip, 0);
            }

            usersParameters[userName][ip]++;

            input = Console.ReadLine();
        }

        foreach (var itemUser in usersParameters.OrderBy(x => x.Key))
        {
            string userName = itemUser.Key;
            Dictionary<string, int> usersIP = itemUser.Value;

            Console.WriteLine($"{userName}:");

            StringBuilder result = new StringBuilder();
            int count = 0;

            foreach (var itemIP in usersIP)
            {
                string ip = itemIP.Key;
                int countNum = itemIP.Value;

                if (count == usersIP.Count - 1)
                {
                    result.Append($"{ip} => {countNum}.");
                }
                else
                {
                    result.Append($"{ip} => {countNum}, ");
                }

                count++;
            }

            Console.WriteLine(result.ToString());
        }
    }
}

