namespace p08._02.MentorGroup
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    class MentorGroup2
    {
        static void Main(string[] args)
        {
            List<Student> students = CreateStudentsData();

            PrintStudentsData(students);
        }

        static void PrintStudentsData(List<Student> students)
        {
            foreach (Student student in students
                .OrderBy(x => x.Name))
            {
                string name = student.Name;
                List<string> comments = student.Comments;
                List<DateTime> dates = student.Dates;

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

        static List<Student> CreateStudentsData()
        {
            string input = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (input.Equals("end of dates") == false)
            {
                string[] inputTokens = input
                    .Split(new char[] { ' ', ',' },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string name = inputTokens[0];
                List<DateTime> dateTimeList = inputTokens
                   .Skip(1)
                   .Select(x => DateTime
                        .ParseExact(
                            x,
                            "dd/MM/yyyy",
                            CultureInfo
                            .InvariantCulture))
                   .ToList();

                if (students.Any(x => x.Name == name) == false)
                {
                    Student student = new Student
                    (
                        name,
                        new List<string>(),
                        dateTimeList
                    );

                    students.Add(student);
                }
                else
                {
                    Student existingStudent = students
                        .Where(x => x.Name == name)
                        .First();

                    existingStudent.Dates.AddRange(dateTimeList);
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

                if (students.Any(x => x.Name == name))
                {
                    Student existingStudent = students
                        .Where(x => x.Name == name)
                        .First();

                    existingStudent.Comments.Add(comment);
                }

                command = Console.ReadLine();
            }

            return students;
        }
    }

    class Student
    {
        public string Name { get; set; }

        public List<string> Comments { get; set; }

        public List<DateTime> Dates { get; set; }

        public Student(
            string name,
            List<string> comments,
            List<DateTime> dates)
        {
            this.Name = name;
            this.Comments = comments;
            this.Dates = dates;
        }
    }
}
