using System;
using System.Linq;

class Batteries
{
    static void Main(string[] args)
    {
        double[] capasity = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();
        double[] usagePerHour = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();
        double hoursForTest = double.Parse(Console.ReadLine());

        for (int i = 0; i < capasity.Length; i++)
        {
            double  result = usagePerHour[i] * hoursForTest;
            double total = capasity[i] - result;
            
            if (total < 0.0)
            {
                double lastedHours = Math.Ceiling(capasity[i] / usagePerHour[i]);

                Console.WriteLine($"Battery {i + 1}: dead (lasted {lastedHours} hours)");
            }
            else
            {
                double percentage = total * 100.0 / capasity[i];

                Console.WriteLine($"Battery {i + 1}: {total:F2} mAh ({percentage:F2})%");
            }

        }
    }
}

