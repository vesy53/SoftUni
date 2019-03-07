using System;
using System.Collections.Generic;
using System.Linq;

class AverageStudentGrades
{
    static void Main(string[] args)
    {
        Dictionary<string, List<double>> studentsBook = new Dictionary<string, List<double>>();
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            string[] inputStudentsArg = Console.ReadLine()
                .Split();

            string name = inputStudentsArg[0];
            double grade = double.Parse(inputStudentsArg[1]);

            if (!studentsBook.ContainsKey(name))
            {
                studentsBook.Add(name, new List<double>());
            }

            studentsBook[name].Add(grade);
        }

        foreach (var studentBook in studentsBook)
        {
            string name = studentBook.Key;
            List<double> grades = studentBook.Value;
            double average = grades.Average();

            Console.Write($"{name} -> ");

            foreach (var grade in grades)
            {
                Console.Write($"{grade:F2} ");
            }

            Console.WriteLine($"(avg: {average:f2})");
        }
    }
}

