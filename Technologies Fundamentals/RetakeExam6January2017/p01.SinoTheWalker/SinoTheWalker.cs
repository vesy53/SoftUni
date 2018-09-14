namespace p01.SinoTheWalker
{
    using System;
    using System.Globalization;

    class SinoTheWalker
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime
                .ParseExact(
                    Console.ReadLine(),
                    "HH:mm:ss",
                    CultureInfo
                    .InvariantCulture);
                   // .InstalledUICulture);
            long numSteps = long.Parse(Console.ReadLine());
            long timeInSecond = long.Parse(Console.ReadLine());

            long steps = numSteps % 86400;
            long timeSec = timeInSecond % 86400;
            long totalStepsInSec = steps * timeSec;

            var timeArrival = time.AddSeconds(totalStepsInSec);

            Console.WriteLine(
                $"Time Arrival: {timeArrival.ToString("HH:mm:ss")}");
        }
    }
}
