using System;

namespace p12Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double holidays = double.Parse(Console.ReadLine());
            double weekendsInHome = double.Parse(Console.ReadLine());

            double weekendsInSofia = (48 - weekendsInHome) * 3.0 / 4;
            double totalWeeksInHome = weekendsInHome;
            double totalHolidays = holidays * 2.0 / 3;
            double total = weekendsInSofia + totalWeeksInHome + totalHolidays;
            double totalYeap = 0.0;

            if (year == "leap")
            {
                totalYeap = total * 0.15;
            }

            double result = Math.Truncate(total + totalYeap);

            Console.WriteLine(result);
        }
    }
}
