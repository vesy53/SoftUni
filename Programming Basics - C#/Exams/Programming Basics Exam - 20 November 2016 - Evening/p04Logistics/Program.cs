using System;

namespace p04Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLoads = int.Parse(Console.ReadLine());

            double priceMinibus = 0.0;
            double priceTruck = 0.0;
            double priceTrain = 0.0;
            double total = 0.0;
            double totalMinibus = 0.0;
            double totalTruck = 0.0;
            double totalTrain = 0.0;

            for (int i = 1; i <= numLoads; i++)
            {
                int tonnageCargo = int.Parse(Console.ReadLine());

                total += tonnageCargo;

                if (tonnageCargo <= 3)
                {
                    priceMinibus = 200;
                    totalMinibus += tonnageCargo;
                }
                else if (tonnageCargo > 3 && tonnageCargo <= 11)
                {
                    priceTruck = 175;
                    totalTruck += tonnageCargo;
                }
                else if (tonnageCargo >= 12)
                {
                    priceTrain = 120;
                    totalTrain += tonnageCargo;
                }
            }

            priceMinibus *= totalMinibus;
            priceTruck *= totalTruck;
            priceTrain *= totalTrain;
            double average = (priceMinibus + priceTruck + priceTrain) / total;
            double minibus = totalMinibus / total * 100;
            double truck = totalTruck / total * 100;
            double train = totalTrain / total * 100;

            Console.WriteLine($"{average:F2}");
            Console.WriteLine($"{minibus:F2}%");
            Console.WriteLine($"{truck:F2}%");
            Console.WriteLine($"{train:F2}%");
        }
    }
}
