namespace p07._01.AndreyAndBilliard
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class AndreyAndBilliard
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var menu = new Dictionary<string, decimal>();

            for (int i = 0; i < num; i++)
            {
                string[] currentInput = Console.ReadLine()
                    .Split('-');

                string productName = currentInput[0];
                decimal price = decimal.Parse(currentInput[1]);

                if (!menu.ContainsKey(productName))
                {
                    menu.Add(productName, 0);
                }

                menu[productName] = price;
            }

            string input = Console.ReadLine();

            List<Customer> customers = new List<Customer>();

            while (input != "end of clients")
            {
                string[] currentTokens = input
                    .Split(new char[] { '-', ',' },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string name = currentTokens[0];
                string productName = currentTokens[1];
                int quantity = int.Parse(currentTokens[2]);

                if (!menu.ContainsKey(productName))
                {
                    input = Console.ReadLine();

                    continue;
                }

                Customer client = new Customer();

                if (customers.Any(x => x.Name == name))
                {   //взимаме първото съвпадение на името
                    client = customers.First(x => x.Name == name);

                    if (!client.ShopList.ContainsKey(productName))
                    {
                        client.ShopList.Add(productName, 0);
                    }

                    client.ShopList[productName] += quantity;
                }
                else
                {   //ако се среща запърви път
                    client.Name = name;
                    client.ShopList = new Dictionary<string, int>();
                    client.ShopList.Add(productName, 0);
                    client.ShopList[productName] += quantity;

                    customers.Add(client);
                }

                input = Console.ReadLine();
            }

            // List<decimal> totalBills = new List<decimal>();
            decimal total = 0.0M;

            foreach (var customer in customers
                .OrderBy(x => x.Name))
            {
                string name = customer.Name;
                Dictionary<string, int> orders = customer.ShopList;
                decimal bill = customer.Bill;

                Console.WriteLine($"{name}");

                foreach (var order in orders)
                {
                    string productsName = order.Key;
                    int quantity = order.Value;

                    bill += quantity * menu[productsName];

                    Console.WriteLine($"-- {productsName} - {quantity}");
                }

                total += bill;
                //bills.Add(bill);

                Console.WriteLine($"Bill: {bill:F2}");
            }

            Console.WriteLine($"Total bill: {total:F2}");
           // Console.WriteLine($"Total bill: {totalBills.Sum():f2}");
        }
    }

    class Customer
    {
        public string Name { get; set; }

        public Dictionary<string, int> ShopList { get; set; }

        public decimal Bill { get; set; }
    }
}
