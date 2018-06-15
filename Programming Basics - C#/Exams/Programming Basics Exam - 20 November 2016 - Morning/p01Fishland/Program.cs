using System;

namespace p01Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerelPrice = double.Parse(Console.ReadLine());
            double spratsPrice = double.Parse(Console.ReadLine()); 
            double palmwood = double.Parse(Console.ReadLine());
            double horseMackerel = double.Parse(Console.ReadLine());
            double mussels = double.Parse(Console.ReadLine());

            palmwood *= mackerelPrice + mackerelPrice * 0.6;
            horseMackerel *= spratsPrice + spratsPrice * 0.8;
            mussels *= 7.50;

            double total = palmwood + horseMackerel + mussels;

            Console.WriteLine($"{total:F2}");
        }
    }
}
