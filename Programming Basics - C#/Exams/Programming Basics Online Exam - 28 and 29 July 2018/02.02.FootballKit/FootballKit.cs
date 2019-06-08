namespace _02._02.FootballKit
{
    using System;

    class FootballKit
    {
        static void Main(string[] args)
        {
            double sumTShirt = double.Parse(Console.ReadLine());
            double limit = double.Parse(Console.ReadLine());

            double shorts = sumTShirt * 0.75;
            double socks = shorts * 0.2;
            double buttons = 2 * (sumTShirt + shorts);

            double totalPrice = sumTShirt + shorts + socks + buttons;

            totalPrice -= totalPrice * 0.15;

            if (totalPrice >= limit)
            {
                Console.WriteLine(
                    "Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {totalPrice:F2} lv.");
            }
            else if (totalPrice< limit)
            {
                limit -= totalPrice;

                Console.WriteLine(
                    "No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {limit:F2} lv. more.");
            }
        }
    }
}
