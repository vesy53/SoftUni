using System;

namespace p12EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            int previous = 0;
            int difference = 0;
            int maxDiff = 0;

            for (int i = 0; i < number; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                sum = num1 + num2;
                difference = Math.Abs(num1 + num2 - previous);
                previous = sum;

                if (difference > maxDiff && sum != difference)
                {
                    maxDiff = difference;
                }

            }

            if (difference != 0 && sum != difference)
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
            else
            {
                Console.WriteLine($"Yes, value={sum}");
            }
        }
    }
}
