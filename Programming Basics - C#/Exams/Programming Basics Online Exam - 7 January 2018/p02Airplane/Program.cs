using System;

namespace p02Airplane
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int flightDuration = int.Parse(Console.ReadLine());

            int totalMin = flightDuration + minutes;
            int totalHours = totalMin / 60;
            int resultMin = totalMin % 60;
            totalHours += hours;

            if (totalHours >= 24)
            {
                totalHours -= 24;
            }

            Console.WriteLine($"{totalHours}h {resultMin}m");
        }
    }
}
