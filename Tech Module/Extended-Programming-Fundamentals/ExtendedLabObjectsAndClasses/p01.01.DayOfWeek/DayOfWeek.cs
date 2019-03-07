using System;
using System.Globalization;

class DayOfWeek
{
    static void Main(string[] args)
    {
        string inputDate = Console.ReadLine();

        DateTime date = DateTime
            .ParseExact(
                inputDate, 
                "d-M-yyyy",
                CultureInfo
                .InvariantCulture);

        Console.WriteLine(date.DayOfWeek);
    }
}

