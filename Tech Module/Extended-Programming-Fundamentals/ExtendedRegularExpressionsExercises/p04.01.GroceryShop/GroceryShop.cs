namespace p04._01.GroceryShop
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class GroceryShop
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, decimal>();

            Regex pattern = new Regex(@"^[A-Z][a-z]+:\d+\.\d{2}$");

            string input = Console.ReadLine();

            while (input.Equals("bill") == false)
            {               
                if (pattern.IsMatch(input))
                {
                    string[] inputTokens = input
                    .Split(':');

                    string productName = inputTokens[0];
                    decimal price = decimal.Parse(inputTokens[1]);
                 
                    data[productName] = price;
                }

                input = Console.ReadLine();
            }

            foreach (var itemData in data
                .OrderByDescending(x => x.Value))
            {
                string productName = itemData.Key;
                decimal price = itemData.Value;

                Console.WriteLine(
                    $"{productName} costs {price:F2}");
            }
        }
    }
}
