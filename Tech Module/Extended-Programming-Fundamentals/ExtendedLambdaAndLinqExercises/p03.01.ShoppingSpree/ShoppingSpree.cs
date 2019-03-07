using System;
using System.Collections.Generic;
using System.Linq;

class ShoppingSpree
{
    static void Main(string[] args)
    {
        var shoppingList = new Dictionary<string, decimal>();

        decimal boudget = decimal.Parse(Console.ReadLine());

        string input = Console.ReadLine();

        while (input.Equals("end") == false)
        {
            string[] inputTokens = input
                .Split();

            string product = inputTokens[0];
            decimal price = decimal.Parse(inputTokens[1]);

            if (!shoppingList.ContainsKey(product))
            {
                shoppingList.Add(product, price);
            }

            if (shoppingList[product] > price)
            {
                shoppingList[product] = price;
            }

            input = Console.ReadLine();
        }

        decimal sum = shoppingList
            .Sum(x => x.Value);

        if (sum > boudget)
        {
            Console.WriteLine("Need more money... Just buy banichka");
        }
        else if(sum <= boudget)
        {
            foreach (var shopingData in shoppingList
                .OrderByDescending( x => x.Value)
                .ThenBy(x => x.Key.Length))
            {
                string product = shopingData.Key;
                decimal price = shopingData.Value;

                Console.WriteLine($"{product} costs {price:F2}");
            }
        }
    }
}

