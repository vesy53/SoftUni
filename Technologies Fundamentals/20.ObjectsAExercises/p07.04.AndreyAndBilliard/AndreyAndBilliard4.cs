namespace p07._04.AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AndreyAndBilliard4
    {//60/100
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var menu = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split('-');

                string productName = input[0];
                decimal price = decimal.Parse(input[1]);

                if (!menu.ContainsKey(productName))
                {
                    menu.Add(productName, price);
                }
                else
                {
                    menu[productName] = price;
                }
            }

            Customer newCustomer = new Customer();

            string command = Console.ReadLine();

            while (command != "end of clients")
            {
                string[] commandTokens = command
                    .Split(new char[] { '-', ',' },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string name = commandTokens[0];
                string product = commandTokens[1];
                decimal quantity = decimal.Parse(commandTokens[2]);

                if (menu.ContainsKey(product))
                {
                    if (!newCustomer.ShopList.ContainsKey(name))
                    {
                        newCustomer.ShopList.Add(name, new Dictionary<string, decimal>());
                    }

                    if (!newCustomer.ShopList[name].ContainsKey(product))
                    {
                        newCustomer.ShopList[name].Add(product, 0);
                    }
                 
                    newCustomer.ShopList[name][product] += quantity;

                    decimal bill = quantity * menu[product];

                    if (!newCustomer.Bills.ContainsKey(name))
                    {
                        newCustomer.Bills.Add(name, 0.0M);
                    }

                    newCustomer.Bills[name] += bill;
                }

                command = Console.ReadLine();
            }

            foreach (var client in newCustomer
                .Bills
                .OrderBy(x => x.Key)
                .ThenBy(x => x.Value))
            {
                string name = client.Key;
                decimal bill = client.Value;

                Console.WriteLine($"{name}");

                foreach (var pair in newCustomer.ShopList)
                {
                    string name2 = pair.Key;
                    Dictionary<string, decimal> shopList = pair.Value;

                    foreach (var list in shopList)
                    {
                        string product = list.Key;
                        decimal quantity = list.Value;

                        if (name2 == name)
                        {
                            Console.WriteLine($"-- {product} - {quantity}");
                        }
                    }
                }

                Console.WriteLine($"Bill: {bill:F2}");
            }

            Console.WriteLine($"Total bill: {newCustomer.Bills.Sum(x => x.Value)}");
        }
    }

    class Customer
    {
        public Dictionary<string, Dictionary<string, decimal>> ShopList = new Dictionary<string, Dictionary<string, decimal>>();
        public Dictionary<string, decimal> Bills { get; set; } = new Dictionary<string, decimal>();
    }
}
