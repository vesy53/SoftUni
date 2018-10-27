using System;

namespace p09RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int lastDigit = 0;
                int sum = i;

                while (sum > 0)
                {
                    lastDigit += sum % 10;
                    sum /= 10;
                }

                bool isSpecial = (lastDigit == 5) || (lastDigit == 7) || (lastDigit == 11);

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
