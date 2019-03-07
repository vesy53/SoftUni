namespace p01._02.SinoTheWalker
{
    using System;

    class SinoTheWalker2
    {
        static void Main(string[] args)
        {
            TimeSpan time = TimeSpan.Parse(Console.ReadLine());
            long numSteps = long.Parse(Console.ReadLine());
            long timeInSecond = long.Parse(Console.ReadLine());

            long steps = numSteps % 86400;
            long timeSec = timeInSecond % 86400;

            long totalTimeInSec = steps * timeSec;

            TimeSpan result = TimeSpan.FromSeconds(totalTimeInSec);

            Console.WriteLine($"Time Arrival: {result:hh\\:mm\\:ss}");
        }
    }
}
