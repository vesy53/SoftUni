using System;

namespace p04Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());

            double totalElect = 0.0;
            double water =  20;
            double internet = 15;
            double other = 0.0;
            double tax = 0.0;
            double otherPerMonth = 0.0;

            for (int i = 0; i < month; i++)
            {
                double electricity = double.Parse(Console.ReadLine());

                totalElect += electricity;

                other = electricity + water + internet;
                tax = other * 0.2;
                otherPerMonth += other + tax;
            }

            water *= month;
            internet *= month;
            double average = 
                (totalElect + water + internet + otherPerMonth) / month;

            Console.WriteLine($"Electricity: {totalElect:F2} lv");
            Console.WriteLine($"Water: {water:F2} lv");
            Console.WriteLine($"Internet: {internet:F2} lv");
            Console.WriteLine($"Other: {otherPerMonth:F2} lv");
            Console.WriteLine($"Average: {average:F2} lv");
        }
    }
}
