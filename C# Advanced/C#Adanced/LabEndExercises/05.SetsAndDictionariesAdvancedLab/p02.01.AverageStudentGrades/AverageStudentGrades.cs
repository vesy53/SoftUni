namespace p02._01.AverageStudentGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, List<double>>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string name = tokens[0];
                double grade = double.Parse(tokens[1]);

                if (!data.ContainsKey(name))
                {
                    data.Add(name, new List<double>());
                }

                data[name].Add(grade);
            }

            foreach (var itemData in data)
            {
                string name = itemData.Key;
                List<double> grades = itemData.Value;

                double average = grades.Average();

                Console.Write($"{name} -> ");

                foreach (double grade in grades)
                {
                    Console.Write($"{grade:F2} ");
                }

                Console.WriteLine($"(avg: {average:F2})");
            }
        }
    }
}
