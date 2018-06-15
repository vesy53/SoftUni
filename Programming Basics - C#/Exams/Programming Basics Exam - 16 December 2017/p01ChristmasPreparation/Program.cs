using System;

namespace p01ChristmasPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            double wrappingPaper = double.Parse(Console.ReadLine());
            double rollsCloth = double.Parse(Console.ReadLine());
            double literGlue = double.Parse(Console.ReadLine());
            double percentageDec = double.Parse(Console.ReadLine());

            double priceWrapingPaper = 5.80 * wrappingPaper;
            double priceCloth = 7.20 * rollsCloth;
            double priceGlue = 1.20 * literGlue;
            double total = priceWrapingPaper + priceCloth + priceGlue;
            double totalDec = total - ((total * percentageDec) / 100);

            Console.WriteLine($"{totalDec:F3}");
        }
    }
}
