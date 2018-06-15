using System;

namespace p04Salary2
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = double.Parse(Console.ReadLine());
            int retiredTime = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            int moreYears = 0;

            for (int i = 1; i <= 80; i++)
            {
                salary += salary * 0.06;

                if (i % 10 == 5)
                {
                    salary += 100;
                }

                if (i % 10 == 0)
                {
                    salary += 200;
                }

                if (text == "yes" && i % 10 != 5 && i % 10 != 0)
                {
                    salary -= salary * 0.01;
                    //salary *= 0.99;
                }

                if (i == retiredTime && salary < 5000)
                {
                    Console.WriteLine($"Current salary: {salary:F2}");
                }

                if (salary >= 5000 && i <= retiredTime)
                {
                    salary = 5000;

                    Console.WriteLine($"Current salary: {salary:F2}\r\n" +
                        $"0 more years to max salary.");
                    return;
                }

                if (salary >= 5000)
                {
                    moreYears = i - 1 - retiredTime;

                    Console.WriteLine($"{moreYears} more years to max salary.");
                    return;
                }
            }          
        }
    }
}
