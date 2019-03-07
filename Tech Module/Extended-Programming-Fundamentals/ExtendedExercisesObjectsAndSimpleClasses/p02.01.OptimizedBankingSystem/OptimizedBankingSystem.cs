using System;
using System.Linq;
using System.Collections.Generic;

class OptimizedBankingSystem
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        List<BankAccount> data = new List<BankAccount>();

        while (input.Equals("end") == false)
        {
            string[] inputTokens = input
                .Split(new string[] { " | " },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            BankAccount information = new BankAccount
            {
                Bank = inputTokens[0],
                Name = inputTokens[1],
                Balance = decimal.Parse(inputTokens[2])
            };

            data.Add(information);

            input = Console.ReadLine();
        }

        foreach (var itemData in data
            .OrderByDescending(x => x.Balance)
            .ThenBy(x => x.Bank))
        {
            string bank = itemData.Bank;
            string name = itemData.Name;
            decimal balance = itemData.Balance;

            Console.WriteLine(
                $"{name} -> {balance} ({bank})");
        }
    }
}

class BankAccount
{
    public string Name { get; set; }
    public string Bank { get; set; }
    public decimal Balance { get; set; }
}