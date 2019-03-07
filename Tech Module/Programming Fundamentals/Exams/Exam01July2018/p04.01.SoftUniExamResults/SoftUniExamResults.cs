namespace p04._01.SoftUniExamResults
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class SoftUniExamResults
    {
        static void Main(string[] args)
        {
            var dataStudents = new Dictionary<string, int>();
            var dataLanguages = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input.Equals("exam finished") == false)
            {
                string[] tokens = input
                     .Split('-');
                string username = tokens[0];

                if (tokens.Length == 3)
                {
                    string language = tokens[1];
                    int points = int.Parse(tokens[2]);

                    if (!dataStudents.ContainsKey(username))
                    {
                        dataStudents.Add(username, 0);
                    }

                    if (dataStudents[username] < points)
                    {
                        dataStudents[username] = points;
                    }

                    if (!dataLanguages.ContainsKey(language))
                    {
                        dataLanguages.Add(language, 0);
                    }

                    dataLanguages[language]++;
                }
                else if (tokens.Length == 2)
                {
                    string banCommand = tokens[1];

                    if (banCommand == "banned")
                    {
                        dataStudents.Remove(username);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");

            foreach (var student in dataStudents
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                string username = student.Key;
                int points = student.Value;

                Console.WriteLine($"{username} | {points}");
            }

            Console.WriteLine("Submissions:");

            foreach (var data in dataLanguages
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                string language = data.Key;
                int count = data.Value;

                Console.WriteLine($"{language} - {count}");
            }
        }
    }
}
