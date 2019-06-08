namespace _05._01.FanShop
{
    using System;

    class FanShop
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int numsArticle = int.Parse(Console.ReadLine());

            int price = 0;

            for (int i = 0; i < numsArticle; i++)
            {
                string article = Console.ReadLine();

                if (article == "hoodie")
                {
                    price += 30;
                }
                else if (article == "keychain")
                {
                    price += 4;
                }
                else if (article == "T-shirt")
                {
                    price += 20;
                }
                else if (article == "flag")
                {
                    price += 15;
                }
                else if (article == "sticker")
                {
                    price += 1;
                }
            }

            if (budget >= price)
            {
                budget -= price;

                Console.WriteLine(
                    $"You bought {numsArticle} items and left with {budget} lv.");
            }
            else if (budget < price)
            {
                price -= budget;

                Console.WriteLine(
                    $"Not enough money, you need {price} more lv.");
            }
        }
    }
}
