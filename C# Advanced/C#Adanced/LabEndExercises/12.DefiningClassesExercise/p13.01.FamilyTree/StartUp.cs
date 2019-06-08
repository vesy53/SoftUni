namespace p13._01.FamilyTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static List<Person> persons;

        static void Main(string[] args)
        {
            persons = new List<Person>();
            List<string> information = new List<string>();

            string inputData = Console.ReadLine();
            string input = Console.ReadLine();

            while (input.Equals("End") == false)
            {
                if (input.Contains("-"))
                {
                    information.Add(input);

                    input = Console.ReadLine();
                    continue;
                }

                string[] tokens = input
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string name = string
                    .Format($"{tokens[0]} {tokens[1]}");
                string birthday = tokens[2];

                Person person = new Person(name, birthday);

                persons.Add(person);

                input = Console.ReadLine();
            }

            foreach (string info in information)
            {
                string[] inputArg = info
                    .Split(new string[] { " - " },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string parentInfo = inputArg[0];
                string childInfo = inputArg[1];

                Person parent = GetPerson(parentInfo);
                Person child = GetPerson(childInfo);

                parent.AddChild(child);
                child.AddParent(parent);
            }

            PrintTheResult(inputData);
        }

        static void PrintTheResult(string inputData)
        {
            Person searchPerson = GetPerson(inputData);

            Console.WriteLine(searchPerson);
            Console.WriteLine("Parents:");

            searchPerson.Parents
                .ForEach(c => Console.WriteLine(c));

            Console.WriteLine("Children:");

            searchPerson.Children
                .ForEach(c => Console.WriteLine(c));
        }

        static Person GetPerson(string info)
        {
            Person person;

            if (info.Contains("/"))
            {
                person = persons
                    .FirstOrDefault(p => p.Birthday == info);
            }
            else
            {
                person = persons
                    .First(p => p.Name == info);
            }

            return person;
        }
    }
}