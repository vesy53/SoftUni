namespace p01._01.GoogleSearches
{
    using System;

    class GoogleSearches
    {
        static void Main(string[] args)
        {
            long days = long.Parse(Console.ReadLine());
            long numUsers = long.Parse(Console.ReadLine());
            decimal moneyPerSearch = decimal.Parse(Console.ReadLine());

            decimal money = 0.0m;
            decimal total = 0.0m;

            for (int i = 1; i <= numUsers; i++)
            {
                long words = long.Parse(Console.ReadLine());

                money = moneyPerSearch;

                if (words >= 6)
                {
                    continue;
                }

                if (words == 1)
                {
                    money *= 2;
                }

                if (i % 3 == 0)
                {
                    money *= 3;
                }

                total += money;
            }

            total *= days;

            Console.WriteLine(
                $"Total money earned for {days} days: {total:F2}");
        }
    }
}
