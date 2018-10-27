using System;
using System.Collections.Generic;
using System.Linq;

class PhonebookUpgrade1
{
    static void Main(string[] args)
    {
        SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
        List<string> command = Console.ReadLine()
            .Split()
            .ToList();

        while (command[0] != "END")
        {
            if (command[0] == "A")
            {
                string name = command[1];
                string phoneNumber = command[2];

                phonebook[name] = phoneNumber;
            }
            else if (command[0] == "S")
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
            else if (command[0] == "ListAll")
            {
                foreach (KeyValuePair<string, string> phone in phonebook)
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

