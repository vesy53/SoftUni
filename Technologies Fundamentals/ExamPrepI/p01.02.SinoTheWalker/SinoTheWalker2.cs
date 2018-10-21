namespace p01._02.SinoTheWalker
{
    using System;

    class SinoTheWalker2
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Parse(Console.ReadLine());
            int steps = int.Parse(Console.ReadLine());
            int stepsPerSec = int.Parse(Console.ReadLine());

            //махаме цели дни, ако някой се прави на интересен да ни ги подава като вход
            //86400 секунди = 1 ден
            steps %= 86400;
            stepsPerSec %= 86400;
            int totalTime = steps * stepsPerSec;
            DateTime result = startTime.AddSeconds(totalTime);

            Console.WriteLine("Time Arrival: {0:HH:mm:ss}", result);
        }
    }
}
