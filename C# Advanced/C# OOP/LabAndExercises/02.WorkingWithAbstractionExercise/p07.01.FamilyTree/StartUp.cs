namespace p07._01.FamilyTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private static List<Person> tree;

        public static void Main(string[] args)
        {
            tree = new List<Person>();
            List<string> inputData = new List<string>();

            string inputInfo = Console.ReadLine();
            string command = Console.ReadLine();

            while (command.Equals("End") == false)
            {
                if (command.Contains("-"))
                {
                    inputData.Add(command);
                }
                else
                {
                    string[] personArgs = command
                        .Split(' ',
                            StringSplitOptions
                            .RemoveEmptyEntries);

                    string name = $"{personArgs[0]} {personArgs[1]}";
                    string birthday = personArgs[2];

                    Person currPerson = new Person(name, birthday);

                    tree.Add(currPerson);
                }

                command = Console.ReadLine();
            }

            foreach (string data in inputData)
            {
                string[] dataInfo = data
                    .Split(new string[] { " - " },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string parentInfo = dataInfo[0].Trim();
                string childInfo = dataInfo[1].Trim();

                Person currParent = GetPerson(parentInfo);
                Person currChild = GetPerson(childInfo);

                currParent.AddChild(currChild);
                currChild.AddParent(currParent);
            }

            Person searchPerson = GetPerson(inputInfo);

            Console.WriteLine(searchPerson);
        }

        static Person GetPerson(string info)
        {
            Person cuurPerson;

            if (info.Contains("/"))
            {
                cuurPerson = tree
                    .First(p => p.Birthday == info);
            }
            else
            {
                cuurPerson = tree
                    .FirstOrDefault(p => p.Name == info);
            }

            return cuurPerson;
        }
    }
}
