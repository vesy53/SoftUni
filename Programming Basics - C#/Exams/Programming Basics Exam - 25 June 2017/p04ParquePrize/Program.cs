using System;

namespace p04ParquePrize
{
    class Program
    {
        static void Main(string[] args)
        {
            int partsDivided = int.Parse(Console.ReadLine());
            double moneyForPoint = double.Parse(Console.ReadLine());

            double total = 0.0;

            for (int i = 1; i <= partsDivided; i++)
            {
                int points = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    points *= 2;
                }

                total += points;
            }

            moneyForPoint *= total;

            Console.WriteLine(
                $"The project prize was {moneyForPoint:F2} lv.");
        }
    }
}
