using System;
using System.Linq;

namespace p06Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] price = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();
            long jewelsPrice = price[0];
            long goldPrice = price[1];
            string[] command = Console.ReadLine()
                .Split();
            
            int countJewels = 0;
            int countGold = 0;
            long totalExpenses = 0L;

            while (command[0] != "Jail" && command[1] != "Time")
            {
                string loot = command[0];
                long heistExpenses = long.Parse(command[1]);

                foreach (var l in loot)
                {
                    if (l == '%')
                    {
                        countJewels++;
                    }

                    if (l == '$')
                    {
                        countGold++;
                    }
                }            

                totalExpenses += heistExpenses;

                command = Console.ReadLine().Split();
            }

            long totalEarnings = countJewels * jewelsPrice + countGold * goldPrice;
            long total = Math.Abs(totalEarnings - totalExpenses);

            if (totalEarnings >= totalExpenses)
            {
                Console.WriteLine(
                    $"Heists will continue. Total earnings: {total}.");
            }
            else if (totalEarnings < totalExpenses)
            {
                Console.WriteLine(
                    $"Have to find another job. Lost: {total}.");
            }
        }
    }
}
