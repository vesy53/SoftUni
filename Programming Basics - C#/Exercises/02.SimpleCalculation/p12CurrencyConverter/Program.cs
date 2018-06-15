using System;

namespace p12CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string inputCurrency = Console.ReadLine();
            string outputCurrency = Console.ReadLine();

            string currency = "BGN";

            if (inputCurrency == "USD")
            {
                num *= 1.79549;
            }
            else if (inputCurrency == "EUR")
            {
                num *= 1.95583;
            }
            else if (inputCurrency == "GBP")
            {
                num *= 2.53405;
            }

            if (outputCurrency == "USD")
            {
                num /= 1.79549;
                currency = "USD";
            }
            else if (outputCurrency == "EUR")
            {
                num /= 1.95583;
                currency = "EUR";
            }
            else if (outputCurrency == "GBP")
            {
                num /= 2.53405;
                currency = "GBP";
            }

            Console.WriteLine($"{num:F2} {currency}");
        }
    }
}
