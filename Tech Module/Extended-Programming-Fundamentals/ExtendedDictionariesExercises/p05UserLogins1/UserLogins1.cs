using System;
using System.Collections.Generic;

class UserLogins1
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

            bool isSuccessfu = false;

            if (usersLogin.ContainsKey(username)
                && usersLogin.ContainsValue(password))
            {
                isSuccessfu = true;
            }

            if (isSuccessfu)
            {
                Console.WriteLine($"{username}: logged in successfully");
            }
            else
            {
                failedCount++;
                Console.WriteLine($"{username}: login failed");
            }

            command = Console.ReadLine()
                .Split(new char[] { ' ', '-', '>' }
                    , StringSplitOptions
                    .RemoveEmptyEntries);
        }

        Console.WriteLine($"unsuccessful login attempts: {failedCount}");
    }
}

