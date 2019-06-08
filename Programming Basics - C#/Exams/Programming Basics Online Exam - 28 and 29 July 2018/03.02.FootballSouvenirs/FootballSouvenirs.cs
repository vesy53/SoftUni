namespace _03._02.FootballSouvenirs
{
    using System;

    class FootballSouvenirs
    {
        private static string tim;
        private static string souvenirs;
        private static int numberSouvenirs;
        private static double price;

        static void Main(string[] args)
        {
            tim = Console.ReadLine();
            souvenirs = Console.ReadLine();
            numberSouvenirs = int.Parse(Console.ReadLine());

            price = 0.0;

            if (souvenirs == "flags")
            {
                if (tim == "Argentina")
                {
                    price = 3.25;
                }
                else if (tim == "Brazil")
                {
                    price = 4.20;
                }
                else if (tim == "Croatia")
                {
                    price = 2.75;
                }
                else if (tim == "Denmark")
                {
                    price = 3.10;
                }

                TakeResult();
            }
            else if (souvenirs == "caps")
            {
                if (tim == "Argentina")
                {
                    price = 7.20;
                }
                else if (tim == "Brazil")
                {
                    price = 8.50;
                }
                else if (tim == "Croatia")
                {
                    price = 6.90;
                }
                else if (tim == "Denmark")
                {
                    price = 6.50;
                }

                TakeResult();
            }
            else if (souvenirs == "posters")
            {
                if (tim == "Argentina")
                {
                    price = 5.10;
                }
                else if (tim == "Brazil")
                {
                    price = 5.35;
                }
                else if (tim == "Croatia")
                {
                    price = 4.95;
                }
                else if (tim == "Denmark")
                {
                    price = 4.80;
                }

                TakeResult();
            }
            else if (souvenirs == "stickers")
            {
                if (tim == "Argentina")
                {
                    price = 1.25;
                }
                else if (tim == "Brazil")
                {
                    price = 1.20;
                }
                else if (tim == "Croatia")
                {
                    price = 1.10;
                }
                else if (tim == "Denmark")
                {
                    price = 0.90;
                }

                TakeResult();
            }
            else
            {
                Console.WriteLine("Invalid stock!");
            }
        }

        private static void TakeResult()
        {
            if (price == 0)
            {
                Console.WriteLine("Invalid stock!");
            }
            else
            {
                price *= numberSouvenirs;

                Console.WriteLine(
                    $"Pepi bought {numberSouvenirs} {souvenirs} of {tim} for {price:F2} lv.");
            }
        }
    }
}
