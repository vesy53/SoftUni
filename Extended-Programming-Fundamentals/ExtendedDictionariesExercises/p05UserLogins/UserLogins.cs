using System;
using System.Collections.Generic;

class UserLogins
{
    static void Main(string[] args)
    {
        Dictionary<string, string> usersLogin = new Dictionary<string, string>();
        string[] command = Console.ReadLine()
            .Split(new char[] { ' ', '-', '>' }
                , StringSplitOptions
                .RemoveEmptyEntries);

        while (command[0] != "login")
        {
            string username = command[0];
            string password = command[1];

            if (!usersLogin.ContainsKey(username))
            {
                usersLogin.Add(username, string.Empty);
            }

            usersLogin[username] = password;            

            command = Console.ReadLine()
                .Split(new char[] { ' ', '-', '>' }
                    , StringSplitOptions
                    .RemoveEmptyEntries);
        }

        command = Console.ReadLine()
                .Split(new char[] { ' ', '-', '>' }
                    , StringSplitOptions
                    .RemoveEmptyEntries);
        int failedCount = 0;

        while (command[0] != "end")
        {
            string username = command[0];
            string password = command[1];

            if (!usersLogin.ContainsKey(username) 
                || !usersLogin.ContainsValue(password))
            {
                failedCount++;
                Console.WriteLine($"{username}: login failed");
            }
            else
            {
                Console.WriteLine($"{username}: logged in successfully");
            }

            command = Console.ReadLine()
                .Split(new char[] { ' ', '-', '>' }
                    , StringSplitOptions
                    .RemoveEmptyEntries);
        }

        if (failedCount > 0)
        {
            Console.WriteLine($"unsuccessful login attempts: {failedCount}");
        }
    }
}

