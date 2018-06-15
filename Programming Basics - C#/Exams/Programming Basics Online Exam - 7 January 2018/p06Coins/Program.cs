using System;

namespace p06Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal coins = decimal.Parse(Console.ReadLine());

            int counter = 0;

            while (coins > 0)
            {
                if (coins >= 2m)
                {
                    coins -= 2;
                    counter++;
                }
                else if (coins >= 1m)
                {
                    coins -= 1m;
                    counter++;
                }
                else if (coins >= 0.50m)
                {
                    coins -= 0.50m;
                    counter++;
                }
                else if (coins >= 0.20m)
                {
                    coins -= 0.20m;
                    counter++;
                }
                else if (coins >= 0.10m)
                {
                    coins -= 0.10m;
                    counter++;
                }
                else if (coins >= 0.05m)
                {
                    coins -= 0.05m;
                    counter++;
                }
                else if (coins >= 0.02m)
                {
                    coins -= 0.02m;
                    counter++;
                }
                else if (coins >= 0.01m)
                {
                    coins -= 0.01m;
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
