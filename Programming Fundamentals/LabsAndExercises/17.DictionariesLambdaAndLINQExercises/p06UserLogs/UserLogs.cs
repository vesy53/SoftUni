using System;
using System.Collections.Generic;
using System.Linq;

class UserLogs
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
            List<string> helper = new List<string>();

            Console.WriteLine($"{userName}:");

            foreach (var itemIP in usersIP)
            {
                string ip = itemIP.Key;
                int count = itemIP.Value;

                helper.Add($"{ip} => {count}");       
            }

            Console.WriteLine(string.Join(", ", helper) + ".");
        }
    }
}

