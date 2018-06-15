using System;

namespace p01IvanovisFamily
{
    class Program
    {
        static void Main(string[] args)
        {
            double boudget = double.Parse(Console.ReadLine());
            double firstGift = double.Parse(Console.ReadLine());
            double secGift = double.Parse(Console.ReadLine());
            double thirdGift = double.Parse(Console.ReadLine());

            double totalGift = firstGift + secGift + thirdGift;
            double total = (boudget - totalGift) - (boudget - totalGift) * 0.1;

            Console.WriteLine($"{total:F2}");
        }
    }
}
