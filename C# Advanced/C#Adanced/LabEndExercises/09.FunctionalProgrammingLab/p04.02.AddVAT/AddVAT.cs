namespace p04._02.AddVAT
{
    using System;
    using System.Linq;

    class AddVAT
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine()
                .Split(new char[] { ',', ' ' },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(p => p * 1.20)
                .ToArray();

            foreach (double price in prices)
            {
                Console.WriteLine($"{price:F2}");
            }
        }
    }
}