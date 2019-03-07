using System;

namespace p01DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string[] daysName =
            {
                "Invalid Day!",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            if (num >= 1 && num <= 7)
            {
                Console.WriteLine(daysName[num]);
            }
            else
            {
                Console.WriteLine(daysName[0]);
            }        
        }
    }
}
