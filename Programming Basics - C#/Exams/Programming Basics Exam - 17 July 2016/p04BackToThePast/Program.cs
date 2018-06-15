using System;

namespace p04BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());

            int years = 17;

            for (int i = 1800; i <= yearToLive; i++)
            {
                years++;

                if (i % 2 == 0)
                {
                    inheritedMoney -= 12000;
                }
                else
                {
                    inheritedMoney -= 12000 + 50 * years;
                }
            }

            if (inheritedMoney >= 0)
            {
                Console.WriteLine(
                    $"Yes! He will live a carefree life and will " +
                    $"have {inheritedMoney:F2} dollars left.");
            }
            else if (inheritedMoney < 0)
            {
                Console.WriteLine(
                    $"He will need {Math.Abs(inheritedMoney):F2} " +
                    $"dollars to survive.");
            }
        }
    }
}
