using System;
using System.Collections.Generic;

namespace p12MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                bool isMasterNum = IsMasterNumber(i);

                if (isMasterNum)
                {
                    Console.WriteLine(i);
                }
            }         
        }
     
        static bool IsMasterNumber(int i)
        {
            bool isPalindrome = IsPalindrome(i.ToString());
            bool isDivisible = SumOfDigits(i);
            bool isEvenDigit = ContainsEvenDigit(i);

            return isPalindrome && isDivisible && isEvenDigit;
        }

        static bool ContainsEvenDigit(int i)
        {
            while (i != 0)
            {
                int lastDigit = i % 10;
                i /= 10;

                if (lastDigit % 2 == 0)
                {
                    return true;
                }
            }

            return false;
        }

        static bool SumOfDigits(int i)
        {
            int sum = 0;

            while (i != 0)
            {
                int lastDigit = i % 10;
                sum += lastDigit;
                i /= 10;             
            }

            return sum % 7 == 0;
        }

        static bool IsPalindrome(string numString)
        {
            bool isPalindrome = true;
            int length = numString.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (numString[i] != numString[length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }

        
    }
}
