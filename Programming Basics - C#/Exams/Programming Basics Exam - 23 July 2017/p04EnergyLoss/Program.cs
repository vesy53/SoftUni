using System;

namespace p04EnergyLoss
{
    class Program
    {
        static void Main(string[] args)
        {
            int trainingDays = int.Parse(Console.ReadLine());
            int numDancers = int.Parse(Console.ReadLine());

            double lossEnergy = 0.0;

            for (int i = 1; i <= trainingDays; i++)
            {
                int hours = int.Parse(Console.ReadLine());

                if (i % 2 == 0 && hours % 2 == 0)
                {
                    lossEnergy += numDancers * 68;
                }
                else if (i % 2 == 1 && hours % 2 == 0)
                {
                    lossEnergy += numDancers * 49;
                }
                else if (i % 2 == 0 && hours % 2 == 1)
                {
                    lossEnergy += numDancers * 65;
                }
                else if (i % 2 == 1 && hours % 2 == 1)
                {
                    lossEnergy += numDancers * 30;
                }
            }

            double totalEnergy = 100 * numDancers * trainingDays;
            double unlossEnergy = totalEnergy - lossEnergy;
            double unlossEnergyDancer = 
                unlossEnergy / numDancers / trainingDays;

            if (unlossEnergyDancer <= 50)
            {
                Console.WriteLine
                    ($"They are wasted! Energy left: {unlossEnergyDancer:F2}");
            }
            else if (unlossEnergyDancer > 50)
            {
                Console.WriteLine(
                    $"They feel good! Energy left: {unlossEnergyDancer:F2}");
            }
        }
    }
}
