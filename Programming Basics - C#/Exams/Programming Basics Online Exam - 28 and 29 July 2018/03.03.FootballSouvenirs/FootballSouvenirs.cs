namespace _03._03.FootballSouvenirs
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

            if (tim == "Argentina")
            {
                if (souvenirs == "flags")
                {
                    price = 3.25;
                }
                else if (souvenirs == "caps")
                {
                    price = 7.20;
                }
                else if (souvenirs == "posters")
                {
                    price = 5.10;
                }
                else if (souvenirs == "stickers")
                {
                    price = 1.25;
                }

                TakeResult();
            }
            else if (tim == "Brazil")
            {
                if (souvenirs == "flags")
                {
                    price = 4.20;
                }
                else if (souvenirs == "caps")
                {
                    price = 8.50;
                }
                else if (souvenirs == "posters")
                {
                    price = 5.35;
                }
                else if (souvenirs == "stickers")
                {
                    price = 1.20;
                }

                TakeResult();
            }
            else if (tim == "Croatia")
            {
                if (souvenirs == "flags")
                {
                    price = 2.75;
                }
                else if (souvenirs == "caps")
                {
                    price = 6.90;
                }
                else if (souvenirs == "posters")
                {
                    price = 4.95;
                }
                else if (souvenirs == "stickers")
                {
                    price = 1.10;
                }

                TakeResult();
            }
            else if (tim == "Denmark")
            {
                if (souvenirs == "flags")
                {
                    price = 3.10;
                }
                else if (souvenirs == "caps")
                {
                    price = 6.50;
                }
                else if (souvenirs == "posters")
                {
                    price = 4.80;
                }
                else if (souvenirs == "stickers")
                {
                    price = 0.90;
                }

                TakeResult();
            }
            else
            {
                Console.WriteLine("Invalid country!");
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
