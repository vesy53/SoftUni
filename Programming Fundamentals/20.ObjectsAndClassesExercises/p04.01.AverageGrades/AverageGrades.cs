using System;
using System.Collections.Generic;
using System.Linq;

class AverageGrades
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
            double averageGrade = grades.Average();

            Student studentsArgs = new Student
            {
                Name = name,
                Grade = grades,
                AverageGrade = averageGrade
            };

            students.Add(studentsArgs);
        }

        foreach (Student student in students
            .OrderBy(x => x.Name)
            .ThenByDescending(x => x.AverageGrade))
        {
            string name = student.Name;
            double averageGrade = student.AverageGrade;

            if (averageGrade >= 5.00)
            {
                Console.WriteLine(
                    $"{name} -> {averageGrade:F2}");
            }
        }
    }
}

class Student
{
    public string Name { get; set; }

    public List<double> Grade { get; set; }

    public double AverageGrade { get; set; }
}