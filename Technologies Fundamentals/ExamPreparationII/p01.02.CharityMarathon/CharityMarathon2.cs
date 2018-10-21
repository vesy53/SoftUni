namespace p01._02.CharityMarathon
{
    using System;

    class CharityMarathon2
    {
        static void Main(string[] args)
        {
            long days = long.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            long laps = long.Parse(Console.ReadLine());
            long lengthTrack = long.Parse(Console.ReadLine());
            long capasityTrack = long.Parse(Console.ReadLine());
            double donatedMoney = double.Parse(Console.ReadLine());

            long totalCapacity = capasityTrack * days;

            if (totalCapacity <= runners)
            {
                runners = totalCapacity;
            }

            double totalMeters = runners * laps * lengthTrack;
            double totalKM = totalMeters / 1000;
            double money = totalKM * donatedMoney;

            Console.WriteLine($"Money raised: {money:F2}");
        }
    }
}
