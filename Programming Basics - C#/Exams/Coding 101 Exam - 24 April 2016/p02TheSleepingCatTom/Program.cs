using System;

namespace p02TheSleepingCatTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDaysOff = int.Parse(Console.ReadLine());

            int holidayDays = numOfDaysOff * 127;
            int workDays = (365 - numOfDaysOff) * 63;
            int total = holidayDays + workDays;

            if (total <= 30000)
            {
                double result = 30000 - total;
                double hours = result / 60;
                double minutes = result % 60;

                Console.WriteLine($"Tom sleeps well\r\n" +
                    $"{Math.Floor(hours)} hours and {minutes} minutes less for play");
            }
            else if (total > 30000)
            {
                total -= 30000;
                double hours = total / 60;
                double minutes = total % 60;

                Console.WriteLine($"Tom will run away\r\n" +
                    $"{hours} hours and {minutes} minutes more for play");
            }
        } 
    }
}
