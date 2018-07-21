using System;
using System.Collections.Generic;

class FixEmails2
{
    static void Main(string[] args)
    {
        Dictionary<string, string> emailBook = new Dictionary<string, string>();
        string name = Console.ReadLine();

        while (!name.Equals("stop"))
        {
            string email = Console.ReadLine();

            string domain = email.Substring(email.Length - 2).ToLower();

            if (!domain.Equals("us") && !domain.Equals("uk"))
            {
                if (!emailBook.ContainsKey(name))
                {
                    emailBook.Add(name, string.Empty);
                }

                emailBook[name] = email;
            }

            name = Console.ReadLine();
        }

        foreach (KeyValuePair<string, string> item in emailBook)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}

