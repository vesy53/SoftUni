using System;
using System.Collections.Generic;

class Phonebook
{
    static void Main(string[] args)
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        string[] command = Console.ReadLine()
            .Split();

        while (command[0] != "END" )
        {
            if (command[0].Equals("A"))
            {
                string name = command[1];
                string number = command[2];

                if (!phonebook.ContainsKey(name))
                {
                    phonebook.Add(name, string.Empty);
                }

                phonebook[name] = number;
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

            command = Console.ReadLine()
                .Split();
        }
    }
}

