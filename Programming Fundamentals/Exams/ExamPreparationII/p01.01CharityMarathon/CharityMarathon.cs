namespace p01._01.CharityMarathon
{
    using System;

    class CharityMarathon
    {
        static void Main(string[] args)
        {
            int maratonInDays = int.Parse(Console.ReadLine());
            long numOfRunners = long.Parse(Console.ReadLine());
            int averageLaps= int.Parse(Console.ReadLine());
            int lengthOfTheTrack = int.Parse(Console.ReadLine());
            int capacityOfTheTrack = int.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());

            long maxRunners = capacityOfTheTrack * maratonInDays;

            if (maxRunners < numOfRunners)
            {
                numOfRunners = maxRunners;
            }

            long totalMeters = numOfRunners * averageLaps * lengthOfTheTrack;
            long totalKm = totalMeters / 1000;

            double totalMoney = totalKm * moneyPerKm;

            Console.WriteLine($"Money raised: {totalMoney:F2}");
        }
    }
}
