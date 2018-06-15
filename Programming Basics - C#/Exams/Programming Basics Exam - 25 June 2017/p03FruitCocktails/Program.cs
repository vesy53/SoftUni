using System;

namespace p03FruitCocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string sizeCocktail = Console.ReadLine();
            int drinksOrdered = int.Parse(Console.ReadLine());

            double price = 0.0;

            if (fruit == "Watermelon")
            {
                if (sizeCocktail == "small")
                {
                    price = 2 * 56;
                }
                else if (sizeCocktail == "big")
                {
                    price =  5 * 28.70;
                }
            }
            else if (fruit == "Mango")
            {
                if (sizeCocktail == "small")
                {
                    price = 2 * 36.66;
                }
                else if (sizeCocktail == "big")
                {
                    price = 5 * 19.60;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (sizeCocktail == "small")
                {
                    price = 2 * 42.1;
                }
                else if (sizeCocktail == "big")
                {
                    price = 5 * 24.8;
                }
            }
            else if (fruit == "Raspberry")
            {
                if (sizeCocktail == "small")
                {
                    price = 2 * 20;
                }
                else if (sizeCocktail == "big")
                {
                    price = 5 * 15.2;
                }
            }

            double total = price * drinksOrdered;

            if (total > 1000)
            {
                total -= total * 0.5;
            }
            else if (total >= 400 && total <= 1000)
            {
                total -= total * 0.15;
            }

            Console.WriteLine($"{total:F2} lv.");
        }
    }
}
