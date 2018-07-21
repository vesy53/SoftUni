using System;
using System.Collections.Generic;
using System.Linq;

class UserLogs
{
    static void Main(string[] args)
    {
        Dictionary<string, int> usersParameters = new Dictionary<string, int>();
        List<string> inputArguments = Console.ReadLine()
            .Split(new char[] { ' ', '=' }
                , StringSplitOptions
                .RemoveEmptyEntries)
            .ToList();

        int count = 0;

        while (inputArguments[0].Equals("end") == false)
        {
            string ip = inputArguments[1];
            string user = inputArguments[5];

            if (!usersParameters.ContainsKey(ip))
            {
                usersParameters.Add(ip, count);
            }
            else
            {
                count++;
                usersParameters[ip] += count;
            }

            inputArguments = Console.ReadLine()
                .Split(new char[] { ' ', '=' }
                    , StringSplitOptions
                    .RemoveEmptyEntries)
                .ToList();
        }

        //Console.WriteLine($"{inputArguments[5]}");

        foreach (var user in usersParameters)
        {
            Console.WriteLine($"{user.Key} -> {user.Value}");
        }
    }
}

