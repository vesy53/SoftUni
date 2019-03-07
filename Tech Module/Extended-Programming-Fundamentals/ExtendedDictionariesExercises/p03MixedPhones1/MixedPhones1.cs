using System;
using System.Collections.Generic;

class MixedPhones1
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
            string name = phonebook[0];
            string number = phonebook[1];

            long numberPhone;
            bool isDigit = long.TryParse(name, out numberPhone);

            if (isDigit)
            {              
                phonesDict[number] = numberPhone;
            }
            else
            {
                phonesDict[name] = long.Parse(number);
            }


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

