using System;

namespace p04GrandpaStavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDays = int.Parse(Console.ReadLine());

            double liters = 0.0;
            double total = 0.0;

            for (int i = 0; i < numDays; i++)
            {
                double quantity = double.Parse(Console.ReadLine());
                double degrees = double.Parse(Console.ReadLine());

                liters += quantity;
                total += quantity * degrees;
            }

            double totalDegrees = total / liters;

            Console.WriteLine($"Liter: {liters:F2}");
            Console.WriteLine($"Degrees: {totalDegrees:F2}");

            if (totalDegrees <= 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (totalDegrees > 38 && totalDegrees <= 42)
            {
                Console.WriteLine("Super!");
            }
            else if (totalDegrees > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
