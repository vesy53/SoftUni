using System;
using System.Collections.Generic;
using System.Globalization;

class CountWorkingDays
{
    static void Main(string[] args)
    {
        string firstInput = Console.ReadLine();
        string secondInput = Console.ReadLine();

        DateTime startDate = DateTime
            .ParseExact(
                firstInput, 
                "dd-MM-yyyy", 
                CultureInfo
                .InvariantCulture);
        DateTime endDate = DateTime
           .ParseExact(
               secondInput,
               "dd-MM-yyyy",
               CultureInfo
               .InvariantCulture);

        List<string> holidays = new List<string>()
        {
            "1 Jan",
            "3 Mar",
            "1 May",
            "6 May",
            "24 May",
            "6 Sep",
            "22 Sep",
            "1 Nov",
            "24 Dec",
            "25 Dec",
            "26 Dec"
        };

        int workingDays = 0;

        for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
        {
            if (i.DayOfWeek == System.DayOfWeek.Saturday ||
                i.DayOfWeek == System.DayOfWeek.Sunday)
            {
                continue;
            }
            else if (holidays.Contains(i.ToString("d MMM")))
            {
                continue;
            }

            workingDays++;
        }

        Console.WriteLine(workingDays);
    }
}