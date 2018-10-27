namespace p03._03.JSONStringify
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class JSONStringify3
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Student> studentsList = new List<Student>();

            StringBuilder result = new StringBuilder();

            while (input.Equals("stringify") == false)
            {
                string[] inputTokens = input
                    .Split(new char[] { ':', '-', '>', ',', ' ' },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string name = inputTokens[0].Trim();
                string age = inputTokens[1].Trim();
                List<int> grades = inputTokens
                    .Skip(2)
                    .Select(int.Parse)
                    .ToList();

                Student newStudent = new Student
                (
                    name,
                    age,
                    grades
                );

                studentsList.Add(newStudent);

                input = Console.ReadLine();
            }

            result.Append("[");

            for (int i = 0; i < studentsList.Count; i++)
            {
                Student student = studentsList[i];
                string name = student.Name;
                string age = student.Age;

                result.Append(
                    "{name:\"" + name + "\",age:" + age + ",grades:[");
                result.Append(string.Join(", ", student.Grades) + "]}");

                if (i < studentsList.Count - 1)
                {
                    result.Append(",");
                }
            }

            result.Append("]");

            Console.WriteLine(result.ToString());
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public List<int> Grades { get; set; }

        public Student(
            string name,
            string age,
            List<int> grades)
        {
            this.Name = name;
            this.Age = age;
            this.Grades = grades;
        }
    }
}
