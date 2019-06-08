namespace p03._01.ProductShop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ProductShop
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, double>>();

            string input = Console.ReadLine();

            while (input.Equals("Revision") == false)
            {
                string[] tokens = input
                    .Split(new char[] { ',', ' ' },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string shopName = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!data.ContainsKey(shopName))
                {
                    data.Add(shopName, new Dictionary<string, double>());
                }

                //if (!data[shopName].ContainsKey(product))
                //{
                //    data[shopName].Add(product, 0);
                //}
                //
                //data[shopName][product] = price;
                data[shopName].Add(product, price);

                input = Console.ReadLine();
            }

            foreach (var itemData in data
                .OrderBy(i => i.Key))
            {
                string shopName = itemData.Key;
                Dictionary<string, double> productsArgs = itemData.Value;

                Console.WriteLine($"{shopName}->");

                foreach (var productsArg in productsArgs)
                {
                    string product = productsArg.Key;
                    double price = productsArg.Value;

                    Console.WriteLine($"Product: {product}, Price: {price}");
                }
            }
        }
    }
}
