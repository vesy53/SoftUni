using System;

namespace pRate1
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialSum = double.Parse(Console.ReadLine());
            double numMonth = double.Parse(Console.ReadLine());

            double sumSimple = initialSum;
            double sumComplex = initialSum;

            for (int i = 0; i < numMonth; i++)
            {
                sumSimple += initialSum * 0.03;
                sumComplex += sumComplex * 0.027;
            }

            Console.WriteLine(
                $"Simple interest rate: {sumSimple:F2} lv.");
            Console.WriteLine(
                $"Complex interest rate: {sumComplex:F2} lv.");

            double diff = 0.0;
            string rate = "";

            if (sumSimple <= sumComplex)
            {
                diff = sumComplex - sumSimple;
                rate = "complex";
            }
            else if (sumSimple > sumComplex)
            {
                diff = sumSimple - sumComplex;
                rate = "simple";
            }

            Console.WriteLine(
                $"Choose a {rate} interest rate. You will win {diff:F2} lv.");

        }
    }
}
