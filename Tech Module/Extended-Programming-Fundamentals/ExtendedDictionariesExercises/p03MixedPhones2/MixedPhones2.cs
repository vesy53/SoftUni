using System;
using System.Collections.Generic;
using System.Linq;

class MixedPhones2
{
    static void Main(string[] args)
    {
        SortedDictionary<string, long> phonesDict = new SortedDictionary<string, long>();
        string[] phonebook = Console.ReadLine()
            .Split(new char[] { ' ', ':' }
                , StringSplitOptions
                .RemoveEmptyEntries);

        while (phonebook[0] != "Over")
        {
            string name = string.Empty;
            string number = string.Empty;

            bool isDigit = phonebook[0].All(c => char.IsDigit(c));

            if (isDigit)
            {
                number = phonebook[0];
                name = phonebook[1];
            }
            else
            {
                number = phonebook[1];
                name = phonebook[0];
            }

            if (!phonesDict.ContainsKey(name))
            {
                phonesDict.Add(name, 0);
            }

            phonesDict[name] = long.Parse(number);

            phonebook = Console.ReadLine()
            .Split(new char[] { ' ', ':' }
                , StringSplitOptions
                .RemoveEmptyEntries);
        }

        foreach (KeyValuePair<string, long> phone in phonesDict)
        {
            Console.WriteLine($"{phone.Key} -> {phone.Value}");
        }
    }
}

