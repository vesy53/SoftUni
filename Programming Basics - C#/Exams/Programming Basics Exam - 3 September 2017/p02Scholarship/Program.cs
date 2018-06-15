using System;

namespace p02Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double incomeBGN = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double social = 0.0;
            double exellent = 0.0;

            if (averageSuccess >= 5.50)
            {
                exellent = Math.Floor(averageSuccess * 25);
            }

            if (incomeBGN <= minSalary && averageSuccess > 4.50)
            {
                social = Math.Floor(minSalary * 0.35);
            }

            if (incomeBGN < minSalary && averageSuccess < 4.50)
            {
                Console.WriteLine($"You cannot get a scholarship!");
            }
            else if (incomeBGN > minSalary && averageSuccess < 5.50)
            {
                Console.WriteLine($"You cannot get a scholarship!");
            }         
            else if (social > exellent)
            {
                Console.WriteLine(
                    $"You get a Social scholarship {social} BGN");
            }
            else if (social <= exellent)
            {
                Console.WriteLine(
                    $"You get a scholarship for excellent results" +
                    $" {exellent} BGN");
            }
        }
    }
}
