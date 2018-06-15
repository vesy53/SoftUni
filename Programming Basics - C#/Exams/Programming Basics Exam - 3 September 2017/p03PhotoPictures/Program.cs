using System;

namespace p03PhotoPictures
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPhotos = int.Parse(Console.ReadLine());
            string typePhotos = Console.ReadLine();
            string wayOrder = Console.ReadLine();

            double price = 0.0;

            if (typePhotos == "9X13")
            {
                price = numPhotos * 0.16;

                if (numPhotos >= 50)
                {
                    price *= 0.95;
                }
            }
            else if (typePhotos == "10X15")
            {
                price = numPhotos * 0.16;

                if (numPhotos >= 80)
                {
                    price *= 0.97;
                }
            }
            else if (typePhotos == "13X18")
            {
                price = numPhotos * 0.38;

                if (numPhotos >= 50 && numPhotos <= 100)
                {
                    price *= 0.97;
                }
                else if (numPhotos > 100)
                {
                    price *= 0.95;
                }
            }
            else if (typePhotos == "20X30")
            {
                price = numPhotos * 2.90;

                if (numPhotos >= 10 && numPhotos <= 50)
                {
                    price *= 0.93;
                }
                else if (numPhotos > 50)
                {
                    price *= 0.91;
                }
            }

            if (wayOrder == "online")
            {
                price *= 0.98;
            }

            Console.WriteLine($"{price:F2}BGN");
        }
    }
}
