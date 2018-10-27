using System;

namespace p11ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInM = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float timeInSec = hours * 3600 + minutes * 60 + seconds;
            float timePerHours = timeInSec / 3600;

            float metersPerSec = distanceInM / timeInSec;
            float kmPerHour = distanceInM / 1000 / timePerHours;
            float milesPerHour = distanceInM / 1609 / timePerHours;

            Console.WriteLine(metersPerSec);
            Console.WriteLine(kmPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
