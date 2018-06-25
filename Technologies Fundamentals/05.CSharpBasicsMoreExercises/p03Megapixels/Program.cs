using System;

namespace p03Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthImage = int.Parse(Console.ReadLine());
            int heightImage = int.Parse(Console.ReadLine());

            double total = widthImage * heightImage;
            total /= 1000000.0;
            
            Console.WriteLine(
                $"{widthImage}x{heightImage} => {Math.Round(total, 1)}MP");
        }
    }
}
