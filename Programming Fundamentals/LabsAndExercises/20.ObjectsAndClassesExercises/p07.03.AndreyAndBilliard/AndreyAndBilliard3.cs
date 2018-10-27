namespace p07._03.AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AndreyAndBilliard3
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
                    menu[productName] = 0;
                }

                menu[productName] = price;
            }

            var customers = new SortedDictionary<string, Customer>();

            string command = Console.ReadLine();

            while (command != "end of clients")
            {
                List<string> commandList = command
                    .Split(new char[] { '-', ',' },
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .ToList();

                string customerName = commandList[0];
                string product = commandList[1];
                int quantity = int.Parse(commandList[2]);

                if (!menu.ContainsKey(product))
                {
                    command = Console.ReadLine();

                    continue;
                }

                if (!customers.ContainsKey(customerName))
                {
                    customers[customerName] = new Customer()
                    {
                        Name = customerName,
                        ShopList = new Dictionary<string, int>(),
                        Bill = 0M
                    };
                }

                if (!customers[customerName].ShopList.ContainsKey(product))
                {
                    customers[customerName].ShopList.Add(product, 0);
                }

                customers[customerName].ShopList[product] += quantity;
                customers[customerName].Bill += quantity * menu[product];

                command = Console.ReadLine();
            }

            List<Customer> clients = new List<Customer>();

            clients = customers
                .Select(v => v.Value)
                .ToList();

            decimal totalBill = 0;

            foreach (var client in clients)
            {
                string name = client.Name;
                Dictionary<string, int> shopList = client.ShopList;
                decimal bill = client.Bill;

                totalBill += bill;

                Console.WriteLine(name);

                Console.WriteLine(
                    string.Join(
                        Environment.NewLine, shopList.Select(p => $"-- {p.Key} - {p.Value}")));

                Console.WriteLine($"Bill: {bill:F2}");
            }

            Console.WriteLine($"Total bill: {totalBill:F2}");
        }
    }

    class Customer
    {
        public string Name { get; set; }

        public Dictionary<string, int> ShopList = new Dictionary<string, int>();

        public decimal Bill { get; set; }
    }
}
