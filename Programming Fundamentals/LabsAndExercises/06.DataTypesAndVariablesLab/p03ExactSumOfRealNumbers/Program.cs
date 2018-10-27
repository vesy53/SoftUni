using System;

namespace p03ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            decimal sum = 0m;

            for (int i = 0; i < number; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());

                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
