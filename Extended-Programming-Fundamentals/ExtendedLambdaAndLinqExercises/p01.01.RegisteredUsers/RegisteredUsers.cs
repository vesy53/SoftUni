using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class RegisteredUsers
{
    static void Main(string[] args)
    {
        var registeredUsers = new Dictionary<string, DateTime>();

        string input = Console.ReadLine();

        while (input.Equals("end") == false)
        {
            string[] inputTokens = input
                .Split(new string[] { " -> " },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            string usersname = inputTokens[0];
            DateTime data = DateTime
                .ParseExact(inputTokens[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (!registeredUsers.ContainsKey(usersname))
            {
                registeredUsers.Add(usersname, new DateTime());
            }

            registeredUsers[usersname] = data;

            input = Console.ReadLine();
        }

        var result = registeredUsers
            .Reverse()
            .OrderBy(x => x.Value)
            .Take(5)
            .OrderByDescending(x => x.Value)
            .ToDictionary(x => x.Key, x => x.Value)
            .Keys;

        Console.WriteLine(string.Join(Environment.NewLine, result));
    }
}

