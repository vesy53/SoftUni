namespace p03._01.JSONStringify
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class JSONStringify2
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Student> studentsList = new List<Student>();

            while (input.Equals("stringify") == false)
            {
                string[] inputTokens = input
                    .Split(new char[] { ':', '-', '>' },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string name = inputTokens[0].Trim();
                string age = inputTokens[1].Trim();
                List<string> grades = new List<string>();

                if (inputTokens.Length > 2)
                {
                    grades = inputTokens[2]
                        .Split(new string[] { ", ", " " },
                            StringSplitOptions
                            .RemoveEmptyEntries)
                        .ToList();
                }

                Student newStudent = new Student
                (
                    name,
                    age,
                    grades
                );

                studentsList.Add(newStudent);

                input = Console.ReadLine();
            }

            Console.WriteLine(
                $"[{string.Join(",", studentsList)}]");
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public List<string> Grades { get; set; }

        public Student(
            string name,
            string age,
            List<string> grades)
        {
            this.Name = name;
            this.Age = age;
            this.Grades = grades;
        }

        public override string ToString()
        {
            string result = 
                $"{{name:\"{this.Name}\"," +
                $"age:{this.Age}," +
                $"grades:[{string.Join(", ", this.Grades)}]}}";

            return result;
        }
    }
}
