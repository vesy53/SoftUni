namespace p04._01.AddVAT
{
    using System;
    using System.Linq;

    class AddVAT
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine()
                .Split(", ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Func<double, double> funcAddVat = p => p *= 1.20;

            AddVatAndPrint(prices, funcAddVat);
        }

        private static void AddVatAndPrint(
            double[] prices, 
            Func<double, double> funcAddVat)
        {
            double[] newPrices = new double[prices.Length];

            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine(
                    $"{funcAddVat(prices[i]):F2}");
            }
        }
    }
}
