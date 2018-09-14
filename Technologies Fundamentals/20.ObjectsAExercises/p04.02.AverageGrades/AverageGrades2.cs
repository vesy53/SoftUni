using System;
using System.Collections.Generic;
using System.Linq;

class AverageGrades2
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        List<Student> students = new List<Student>();

        for (int i = 0; i < num; i++)
        {
            string[] studentTokens = Console.ReadLine()
                .Split();

            string name = studentTokens[0];
            List<double> grades = studentTokens
                .Skip(1)
                .Select(double.Parse)
                .ToList();

            Student studentsArgs = new Student
            {
                Name = name,
                Grades = grades,
            };

            students.Add(studentsArgs);
        }

        foreach (Student student in students
            .Where(x => x.AverageGrade >= 5.00)
            .OrderBy(x => x.Name)
            .ThenByDescending(x => x.AverageGrade))
        {
            string name = student.Name;
            double averageGrade = student.AverageGrade;

            Console.WriteLine(
                    $"{name} -> {averageGrade:F2}");
        }
    }
}

class Student
{
    public string Name { get; set; }

    public List<double> Grades { get; set; }

    public double AverageGrade
    {
        get
        {
            return Grades.Average();
        }
    }
}