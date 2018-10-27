namespace p01._01.AnonymousDownsite
{
    using System;
    using System.Numerics;

    class AnonymousDownsite
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            decimal totalLoss = 0.0m;

            for (int i = 0; i < num; i++)
            {
                string[] websites = Console.ReadLine()
                    .Split();
                string siteName = websites[0];
                decimal siteVisits = decimal.Parse(websites[1]);
                decimal priceVisit = decimal.Parse(websites[2]);

                totalLoss += siteVisits * priceVisit;

                Console.WriteLine(siteName);
            }
            
            BigInteger power = BigInteger.Pow(securityKey, num);

            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {power}");
        }
    }
}
