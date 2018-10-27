using System;
using System.Collections.Generic;
using System.Linq;

class FixEmails1
{
    static void Main(string[] args)
    {
        Dictionary<string, string> emailBook = new Dictionary<string, string>();
        string name = Console.ReadLine();

        while (name.Equals("stop") == false)
        {
            string email = Console.ReadLine();

            if (!emailBook.ContainsKey(name))
            {
                emailBook.Add(name, email);
            }

            name = Console.ReadLine();
        }

        foreach (KeyValuePair<string, string> item in emailBook
            .Where(x => !x.Value.EndsWith(".us") 
            && !x.Value.EndsWith(".uk")))
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}

