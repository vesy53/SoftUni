namespace p04._04.AddVAT
{
    using System;
    using System.Linq;

    class AddVAT
    {
        static void Main(string[] args)
        {
            string[] prices = Console.ReadLine()
                .Split(new char[] { ',', ' ' },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(p => $"{p * 1.2:F2}")
                .ToArray();

            Console
                .WriteLine(string
                    .Join(Environment
                        .NewLine, prices));
        }
    }
}