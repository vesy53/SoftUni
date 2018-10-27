using System;
using System.Linq;
using System.Collections.Generic;

class PhonebookUpgrade
{
    static void Main(string[] args)
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        List<string> command = Console.ReadLine()
            .Split()
            .ToList();

        while (command[0].Equals("END") == false)
        {
            if (command[0].Equals("A"))
            {
                string name = command[1];
                string phoneNumber = command[2];
               
                phonebook[name] = phoneNumber;
            }
            else if (command[0].Equals("S"))
            {
                string name = command[1];

                if (phonebook.ContainsKey(name))
                {
                    Console.WriteLine($"{name} -> {phonebook[name]}");
                }
                else
                {
                    Console.WriteLine($"Contact {name} does not exist.");
                }
            }
            else if (command[0].Equals("ListAll"))
            {
                foreach (KeyValuePair<string, string> phone in phonebook.OrderBy(p => p.Key))
                {
                    Console.WriteLine($"{phone.Key} -> {phone.Value}");
                }
            }

            command = Console.ReadLine()
                .Split()
                .ToList();
        }
    }
}

