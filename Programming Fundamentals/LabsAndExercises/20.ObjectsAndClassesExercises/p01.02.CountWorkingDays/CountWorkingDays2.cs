using System;
using System.Globalization;
using System.Linq;

class CountWorkingDays2
{
    static void Main(string[] args)
    { //85/100
        DateTime startDate = DateTime
            .ParseExact(Console.ReadLine(),
                "dd-MM-yyyy", 
                CultureInfo
                .InvariantCulture);
        DateTime endDate = DateTime
            .ParseExact(Console.ReadLine(),
                "dd-MM-yyyy",
                CultureInfo
                .InvariantCulture);

        DateTime[] holidays = new DateTime[]
        {
            new DateTime(0001, 01, 01),
            new DateTime(0001, 03, 03),
            new DateTime(0001, 05, 01),
            new DateTime(0001, 05, 06),
            new DateTime(0001, 05, 24),
            new DateTime(0001, 09, 06),
            new DateTime(0001, 09, 22),
            new DateTime(0001, 11, 01),
            new DateTime(0001, 12, 24),
            new DateTime(0001, 12, 25),
            new DateTime(0001, 12, 26)
        };

        int workingDays = 0;

        for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
        {
            DayOfWeek day = i.DayOfWeek;

            DateTime temp = new DateTime(0001, i.Month, i.Day);

            if (!holidays.Contains(temp) && 
               (!day.Equals(DayOfWeek.Saturday) &&
                !day.Equals(DayOfWeek.Sunday)))
            {
                workingDays++;
            }
        }

        Console.WriteLine(workingDays);
    }
}

