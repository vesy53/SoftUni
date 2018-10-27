namespace p08._01.AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class AverageGrades
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            students = ReadStudents(studentsCount);

            var topStudents = students
                  .Where(x => x.AverageGrade >= 5.00)
                  .OrderBy(x => x.Name)
                  .ThenByDescending(x => x.AverageGrade)
                  .ToList();

            File.WriteAllText("output.txt", string.Empty);

            foreach (var student in topStudents)
            {
                string name = student.Name;
                double averageGrade = student.AverageGrade;

                File.AppendAllText
                (
                    "output.txt",
                    $"{name} -> {averageGrade:F2}" +
                    $"{Environment.NewLine}"
                );
            }
        }

        static List<Student> ReadStudents(int studentsCount)
        {
            List<Student> students = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
            {
                string[] currentStudent = Console.ReadLine()
                    .Split();
                string name = currentStudent[0];
                List<double> studentGrades = new List<double>();

                studentGrades.AddRange
                (
                    currentStudent
                        .Where((x, index) => index > 0)
                        .Select(double.Parse)
                 );

                Student student = new Student
                (
                    name, 
                    studentGrades
                );

                students.Add(student);
            }

            return students;
        }
    }

    class Student
    {
        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public Student(string name, List<double> grades)
        {
            this.Name = name;
            this.Grades = grades;
        }

        public double AverageGrade
        {
            get
            {
                return this.Grades.Average();
            }
        }
    }
}
