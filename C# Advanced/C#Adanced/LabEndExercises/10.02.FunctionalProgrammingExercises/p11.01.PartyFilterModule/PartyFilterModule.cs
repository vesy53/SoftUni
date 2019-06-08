namespace p11._01.PartyFilterModule
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PartyFilterModule
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .ToList();

            List<string> startWords = new List<string>();
            List<string> endWords = new List<string>();
            List<int> lens = new List<int>();
            List<string> containsWord = new List<string>();

            string input = Console.ReadLine();

            while (input != "Print")
            {
                string[] tokens = input
                    .Split(';');

                string command = tokens[0];
                string type = tokens[1];
                string parameter = tokens[2];

                if (command == "Add filter")
                {
                    switch (type)
                    {
                        case "Starts with":
                            startWords.Add(parameter);
                            break;

                        case "Ends with":
                            endWords.Add(parameter);
                            break;

                        case "Length":
                            lens.Add(int.Parse(parameter));
                            break;

                        case "Contains":
                            containsWord.Add(parameter);
                            break;
                    }
                }
                else if (command == "Remove filter")
                {
                    switch (type)
                    {
                        case "Starts with":
                            startWords.Remove(parameter);
                            break;

                        case "Ends with":
                            endWords.Remove(parameter);
                            break;

                        case "Length":
                            lens.Remove(int.Parse(parameter));
                            break;

                        case "Contains":
                            containsWord.Remove(parameter);
                            break;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var word in startWords)
            {
                for (int i = 0; i < people.Count; i++)
                {
                    if (people[i].StartsWith(word))
                    {
                        people.Remove(people[i]);
                        i--;
                    }
                }
            }

            foreach (var word in endWords)
            {
                for (int i = 0; i < people.Count; i++)
                {
                    if (people[i].EndsWith(word))
                    {
                        people.Remove(people[i]);
                        i--;
                    }
                }
            }

            foreach (var number in lens)
            {
                for (int i = 0; i < people.Count; i++)
                {
                    if (people[i].Length <= number)
                    {
                        people.Remove(people[i]);
                        i--;
                    }
                }
            }

            foreach (var word in containsWord)
            {
                for (int i = 0; i < people.Count; i++)
                {
                    if (people[i].Contains(word))
                    {
                        people.Remove(people[i]);
                        i--;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", people));
        }
    }
}
