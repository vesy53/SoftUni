using System;
using System.Globalization;
using System.Linq;

class CountWorkingDays3
{
    static void Main(string[] args)
    {
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

        string[] holidays = new string[]
        {
            "01 Jan",
            "03 Mar",
            "01 May",
            "06 May",
            "24 May",
            "06 Sep",
            "22 Sep",
            "01 Nov",
            "24 Dec",
            "25 Dec",
            "26 Dec"
        };

        int workingDays = 0;

        for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
        {
            if (!(i.DayOfWeek == System.DayOfWeek.Saturday) &&
                !(i.DayOfWeek == System.DayOfWeek.Sunday) &&
                !holidays.Contains(i.ToString("dd MMM")))
            {
                workingDays++; 
            }
        }

        Console.WriteLine(workingDays);
    }
}

