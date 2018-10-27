using System;
using System.Collections.Generic;
using System.Linq;

class OptimizedBankingSystem2
{
    static void Main(string[] args)
    {
        List<BankAccount> accounts = new List<BankAccount>();

        accounts = FindBankAccounts(accounts);

        PrintBankAccount(accounts);
    }

    static void PrintBankAccount(List<BankAccount> accounts)
    {
        foreach (var itemData in accounts
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

    static List<BankAccount> FindBankAccounts(List<BankAccount> accounts)
    {
        string input = Console.ReadLine();

        while (input != "end")
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

            accounts.Add(information);

            input = Console.ReadLine();
        }

        return accounts;
    }
}

class BankAccount
{
    public string Name { get; set; }
    public string Bank { get; set; }
    public decimal Balance { get; set; }
}