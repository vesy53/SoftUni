using System;

namespace p01TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            double numTable = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double totalTablecloths =
                numTable * (height + 2 * 0.30) * (width + 2 * 0.30);
            double totalBox = numTable * (height / 2) * (height / 2);
            double priceDollar = totalTablecloths * 7 + totalBox * 9;
            double priceLv = priceDollar * 1.85;

            Console.WriteLine($"{priceDollar:F2} USD");
            Console.WriteLine($"{priceLv:F2} BGN");
        }
   }
}
