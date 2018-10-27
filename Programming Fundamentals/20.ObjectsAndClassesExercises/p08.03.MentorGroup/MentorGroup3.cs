namespace p08._03.MentorGroup
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    class MentorGroup3
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var students = new Dictionary<string, Student>();

            while (input.Equals("end of dates") == false)
            {
                string[] inputTokens = input
                    .Split(new char[] { ' ', ',' },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string name = inputTokens[0];

                List<DateTime> dateTimeList = new List<DateTime>();

                if (inputTokens.Length > 1)
                {
                    dateTimeList = inputTokens
                       .Skip(1)
                       .Select(x => DateTime
                            .ParseExact(
                                x,
                                "dd/MM/yyyy",
                                CultureInfo
                                .InvariantCulture))
                       .ToList();
                }

                if (!students.ContainsKey(name))
                {
                    students[name] = new Student
                    {
                        Name = name,
                        Comments = new List<string>(),
                        Dates = dateTimeList
                    };
                }
                else
                {
                    students[name].Dates.AddRange(dateTimeList);
                }

                input = Console.ReadLine();
            }

            string command = Console.ReadLine();

            while (command.Equals("end of comments") == false)
            {
                string[] commandTokens = command
                    .Split('-');

                string name = commandTokens[0];
                string comment = commandTokens[1];

                if (students.ContainsKey(name))
                {
                    students[name].Comments.Add(comment);
                }

                command = Console.ReadLine();
            }

            foreach (var student in students
                .OrderBy(x => x.Key))
            {
                string name = student.Key;
                List<string> comments = student.Value.Comments;
                List<DateTime> dates = student.Value.Dates;

                Console.WriteLine(name);
                Console.WriteLine("Comments:");

                foreach (var comment in comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");

                foreach (var date in dates
                    .OrderBy(x => x))
                {
                    Console.WriteLine(
                        $"-- {date.ToString("dd/MM/yyyy")}");
                }
            }
        }
    }

    class Student
    {
        public string Name { get; set; }

        public List<string> Comments { get; set; }

        public List<DateTime> Dates { get; set; }
    }
}
