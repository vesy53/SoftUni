using System;
using System.Collections.Generic;
using System.Linq;

class UserLogs2
{
    static void Main(string[] args)
    {
        var usersParameters = new SortedDictionary<string, Dictionary<string, int>>();
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

        foreach (var itemUser in usersParameters)
        {
            string userName = itemUser.Key;
            Dictionary<string, int> usersIP = itemUser.Value;

            Console.WriteLine($"{userName}:");

            foreach (var itemIP in usersIP)
            {
                string ip = itemIP.Key;
                int countNum = itemIP.Value;

                if (ip != usersIP.Keys.Last())
                {
                    Console.Write($"{ip} => {countNum}, ");
                }
                else
                {
                    Console.WriteLine($"{ip} => {countNum}.");               
                }            
            }
        }
    }
}

