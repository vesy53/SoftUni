using System;
using System.Globalization;


class DayOfWeek2
{
    static void Main(string[] args)
    {
        string[] inputDate = Console.ReadLine()
            .Split('-');

        int day = int.Parse(inputDate[0]);
        int month = int.Parse(inputDate[1]);
        int year = int.Parse(inputDate[2]);

        DateTime date = new DateTime(year, month, day);

        Console.WriteLine(date.ToString("dddd",
                          CultureInfo.InvariantCulture));
    }
}

