using System;

namespace p05SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                bool isTrue = false;
                int lastDigit = i % 10;
                int firstDigit = i / 10;
                int sum = lastDigit + firstDigit;
                
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isTrue = true;
                }

                Console.WriteLine($"{i} -> {isTrue}");
            }
        }   
    }
}
