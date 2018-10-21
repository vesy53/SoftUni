namespace p01._03.SinoTheWalker
{
    using System;
    using System.Globalization;

    class SinoTheWalker3
    {
        static void Main(string[] args)
        {
            DateTime leaveTime = DateTime
                .ParseExact(
                    Console.ReadLine(),
                    "HH:mm:ss", 
                    CultureInfo
                    .InvariantCulture);
            double steps = double.Parse(Console.ReadLine());
            double secondsPerStep = double.Parse(Console.ReadLine());

            double totalSeconds = steps * secondsPerStep % 86400;

            DateTime arriveTime = leaveTime.AddSeconds(totalSeconds);

            Console.WriteLine(
                $"Time Arrival: {arriveTime.ToString("HH:mm:ss")}");
        }
    }
}
