namespace p04._05.AddVAT
{
    using System;
    using System.Linq;

    class AddVAT5
    {
        public delegate double SumVat(double num);

        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine()
                .Split(new string[] { ", " },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            SumVat sum = CalcVat;

            foreach (double price in prices)
            {
                double result = sum(price);

                Console.WriteLine($"{result:F2}");
            }
        }

        static double CalcVat(double num) => (num * 1.2);

        //or this mode
        //static double CalcVat(double num)
        //{
        //    return num * 1.2;
        //}
    }
}