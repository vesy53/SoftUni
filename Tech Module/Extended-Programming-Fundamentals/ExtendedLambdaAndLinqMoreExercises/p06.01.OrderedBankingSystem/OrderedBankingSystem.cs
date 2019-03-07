using System;
using System.Linq;
using System.Collections.Generic;

class OrderedBankingSystem
{
    static void Main(string[] args)
    {
        var data = new Dictionary<string, Dictionary<string, decimal>>();

        string input = Console.ReadLine();

        while (input.Equals("end") == false)
        {
            string[] inputTokens = input
                .Split(new string[] { " -> " },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            string bankName = inputTokens[0];
            string account = inputTokens[1];
            decimal balance = decimal.Parse(inputTokens[2]);

            if (!data.ContainsKey(bankName))
            {
                data.Add(bankName, new Dictionary<string, decimal>());
            }

            if (!data[bankName].ContainsKey(account))
            {
                data[bankName].Add(account, 0);
            }

            data[bankName][account] += balance;

            input = Console.ReadLine();
        }

        var sortedData = data
              .OrderByDescending(x => x.Value.Sum(y => y.Value))
              .ThenByDescending(x => x.Value.Max(y => y.Value));

        foreach (var itemData in sortedData)
        {
            string bankName = itemData.Key;
            Dictionary<string, decimal> bankOrdersData = itemData.Value;

            foreach (var bankData in bankOrdersData
                .OrderByDescending(x => x.Value))
            {
                string account = bankData.Key;
                decimal balance = bankData.Value;

                Console.WriteLine(
                    $"{account} -> {balance} ({bankName})");
            }
        }
    }
}

