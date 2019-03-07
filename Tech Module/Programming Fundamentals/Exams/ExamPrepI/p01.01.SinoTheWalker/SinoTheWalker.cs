namespace p01._01.SinoTheWalker
{
    using System;
    using System.Globalization;

    class SinoTheWalker
    {
        static void Main(string[] args)
        {
            DateTime timeToLeavs = DateTime
                .ParseExact(Console.ReadLine(), 
                    "HH:mm:ss",
                    CultureInfo
                    .InvariantCulture);
            int numSteps = int.Parse(Console.ReadLine());
            int timeInSecond = int.Parse(Console.ReadLine());
            //махаме цели дни, ако някой се прави на интересен да ни ги подава като вход
            //86400 секунди = 1 ден
            numSteps %= 86400;
            timeInSecond %= 86400;
            int totalSec = numSteps * timeInSecond;

            timeToLeavs = timeToLeavs.AddSeconds(totalSec);

            Console.WriteLine(
                $"Time Arrival: {timeToLeavs.ToString("HH:mm:ss")}");
        }
    }
}
