using System;
using System.Collections.Generic;
using System.Linq;

class AverageStudentGrades1
{
    static void Main(string[] args)
    {
        Dictionary<string, List<double>> studentsBook = new Dictionary<string, List<double>>();
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            string[] inputStudents = Console.ReadLine()
                .Split();

            string name = inputStudents[0];
            double grades = double.Parse(inputStudents[1]);

            if (studentsBook.ContainsKey(name) == false)
            {
                studentsBook.Add(name, new List<double>());
            }

            studentsBook[name].Add(grades);
        }

        foreach (var item in studentsBook)
        {
            string name = item.Key;
            List<double> grades = item.Value;
            double average = CalculateAverageValue(grades);

            Console.WriteLine("{0} -> {1} (avg: {2:F2})",
                name,
                string.Join(" ", 
                    grades.Select(g => string.Format("{0:F2}", g)).ToArray()),
                average);
        }
    }

    static double CalculateAverageValue(List<double> grades)
    {
        double sum = 0.0;
        
        for (int i = 0; i < grades.Count; i++)
        {
            sum += grades[i];
        }

        double average = sum / grades.Count;

        return average;
    }
}

