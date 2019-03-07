namespace p01._03.SinoTheWalker
{
    using System;
    using System.Numerics;

    class SinoTheWalker3
    {
        static void Main(string[] args)
        {
            string[] time = Console.ReadLine()
                .Split(':');

            long hours = long.Parse(time[0]);
            long minutes = long.Parse(time[1]);
            long seconds = long.Parse(time[2]);

            long numSteps = long.Parse(Console.ReadLine());
            long timeInSeconds = long.Parse(Console.ReadLine());

            long totalTime = hours * 3600 + minutes * 60 + seconds;

            BigInteger resultTime = numSteps * timeInSeconds + totalTime;

            BigInteger arriveHour = resultTime / 3600 % 24;
            BigInteger arriveMinute = resultTime / 60 % 60;
            BigInteger arriveSecond = resultTime % 60;

            Console.WriteLine(
                $"Time Arrival: {arriveHour:00}:{arriveMinute:00}:{arriveSecond:00}");
        }
    }
}
