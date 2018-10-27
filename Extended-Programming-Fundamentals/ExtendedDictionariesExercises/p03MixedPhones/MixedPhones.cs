using System;
using System.Collections.Generic;
using System.Linq;

class MixedPhones
{
    static void Main(string[] args)
    {
        Dictionary<string, long> phonesDict = new Dictionary<string, long>();
        string[] phonebook = Console.ReadLine()
            .Split(new char[] { ' ', ':' }
                , StringSplitOptions
                .RemoveEmptyEntries);

        while (phonebook[0] != "Over")
        {
            string name = phonebook[0];
            string numPhone = phonebook[1];

            long numberPhone;
            bool isDigit = long.TryParse(numPhone, out numberPhone);

            if (isDigit)
            {
                if (!phonesDict.ContainsKey(name))
                {
                    phonesDict.Add(name, 0);
                }

                phonesDict[name] = numberPhone;
            }
            else
            {
                long nameDigit;
                bool isNameDigit = long.TryParse(name, out nameDigit);

                if (isNameDigit)
                {
                    phonesDict[numPhone] = nameDigit;
                }
            }
            

            phonebook = Console.ReadLine()
            .Split(new char[] { ' ', ':' }
                , StringSplitOptions
                .RemoveEmptyEntries);
        }

        foreach (KeyValuePair<string, long> phone in phonesDict.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{phone.Key} -> {phone.Value}");
        }
    }
}

