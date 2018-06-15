using System;

namespace p04Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStudents = int.Parse(Console.ReadLine());

            double counter2 = 0.0;
            double counter3 = 0.0;
            double counter4 = 0.0;
            double counter5 = 0.0;
            double total = 0.0;

            for (int i = 1; i <= numStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                
                total += grade;

                if (grade <= 2.99)
                {
                    counter2++;
                }
                else if (grade >= 3 && grade <= 3.99)
                {
                    counter3++;
                }
                else if (grade >= 4 && grade <= 4.99)
                {
                    counter4++;
                }
                else if (grade >= 5)
                {
                    counter5++;
                }
            }

            Console.WriteLine(
                $"Top students: {counter5 / numStudents * 100:F2}%");
            Console.WriteLine
                ($"Between 4.00 and 4.99: {counter4 / numStudents * 100:F2}%");
            Console.WriteLine
                ($"Between 3.00 and 3.99: {counter3 / numStudents * 100:F2}%");
            Console.WriteLine($"Fail: {counter2 / numStudents * 100:F2}%");
            Console.WriteLine($"Average: {total / numStudents:F2}");
        }
    }
}
