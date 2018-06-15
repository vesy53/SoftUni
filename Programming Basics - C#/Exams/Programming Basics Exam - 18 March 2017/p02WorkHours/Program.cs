using System;

namespace p02WorkHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());

            int totalHour = workers * workDays * 8;

            if (totalHour <= neededHours)
            {
                neededHours -= totalHour;
                double penalties = neededHours * workDays;

                Console.WriteLine
                    ($"{neededHours} overtime\r\nPenalties: {penalties}");
            }
            else if (totalHour > neededHours)
            {
                 totalHour -= neededHours;

                Console.WriteLine($"{totalHour} hours left");
            }
        }
    }
}
