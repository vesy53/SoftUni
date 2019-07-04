namespace p03._01.SumOfCoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumOfCoins
    {
        public static void Main(string[] args)
        {
            string[] inputCoins = Console.ReadLine()
                .Split(": ",
                    StringSplitOptions
                    .RemoveEmptyEntries);
            string[] inputSum = Console.ReadLine()
                .Split(": ",
                    StringSplitOptions
                    .RemoveEmptyEntries);

            int[] availableCoins = inputCoins[1]
                .Split(", ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int targetSum = int.Parse(inputSum[1]);

            Dictionary<int, int> selectedCoins = ChooseCoins(availableCoins, targetSum);

            Console.WriteLine(
                $"Number of coins to take: {selectedCoins.Values.Sum()}");

            foreach (var selectedCoin in selectedCoins)
            {
                int coin = selectedCoin.Key;
                int count = selectedCoin.Value;

                Console.WriteLine(
                    $"{count} coin(s) with value {coin}");
            }
        }

        public static Dictionary<int, int> ChooseCoins(
            IList<int> coins, 
            int targetSum)
        {
            int[] sortedCoins = coins
                .OrderByDescending(coin => coin)
                .ToArray();

            Dictionary<int, int> result = new Dictionary<int, int>();

            int currentSum = 0;
            int coinIndex = 0;

            while (currentSum != targetSum && 
                   coinIndex < sortedCoins.Length)
            {
                int currentCoin = sortedCoins[coinIndex];

                int remainder = targetSum - currentSum;
                int numberOfCoins = remainder / currentCoin;

                if (currentSum + currentCoin <= targetSum)
                {
                    result.Add(currentCoin, numberOfCoins);
                    currentSum += numberOfCoins * currentCoin;
                }

                coinIndex++;
            }

            if (currentSum != targetSum)
            {
                Console.WriteLine("Error");

                Environment.Exit(0);
            }

            return result;
        }
    }
}