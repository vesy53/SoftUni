using System;
using System.Collections.Generic;

class FixEmails
{
    static void Main(string[] args)
    {
        Dictionary<string, string> emailBook = new Dictionary<string, string>();
        string input = Console.ReadLine();

        string name = string.Empty;
        string email = string.Empty;
        int index = 1;

        while (input != "stop")
        {
            if (index % 2 != 0)
            {
                if (!emailBook.ContainsKey(input))
                {
                    emailBook[input] = string.Empty;
                }

                name = input;
            }
            else if (index % 2 == 0)
            {
                email = input;

                emailBook[name] = email;

                if (email.EndsWith(".us") || email.EndsWith(".uk"))
                {
                    emailBook.Remove(name);
                }
            }

            index++;

            input = Console.ReadLine();
        }

        foreach (KeyValuePair<string, string> item in emailBook)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}

