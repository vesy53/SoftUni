using System;
using System.Linq;

namespace p06Heists1
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
            string command = Console.ReadLine(); 

            long totalEarnings = 0L;
            long totalExpenses = 0L;

            while (command != "Jail Time")
            {
                string[] currendCommand = command
                    .Split();
                string loot = currendCommand[0];
                long heistExpenses = long.Parse(currendCommand[1]);

                for (int i = 0; i < loot.Length; i++)
                {
                    if (loot[i] == '%')
                    {
                        totalEarnings += jewelsPrice;
                    }
                    else if (loot[i] == '$')
                    {
                        totalEarnings += goldPrice;
                    }                 
                }

                totalExpenses += heistExpenses;
                command = Console.ReadLine();
            }

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
