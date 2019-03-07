namespace p01._01.CharityMarathon
{
    using System;

    class CharityMarathon
    {
        static void Main(string[] args)
        {
            long maratonsDays = long.Parse(Console.ReadLine());
            long numRunners = long.Parse(Console.ReadLine());
            long laps = long.Parse(Console.ReadLine());
            long lengthTrack = long.Parse(Console.ReadLine());
            long capacityTrack = long.Parse(Console.ReadLine());
            decimal money = decimal.Parse(Console.ReadLine());

            long maxRunners = capacityTrack * maratonsDays;

            if (maxRunners > numRunners)
            {
                maxRunners = numRunners;
            }

            long totalMeters = maxRunners * laps * lengthTrack;
            long totalKm = totalMeters / 1000;
            decimal totalMoney = totalKm * money;

            Console.WriteLine($"Money raised: {totalMoney:F2}");
        }
    }
}
