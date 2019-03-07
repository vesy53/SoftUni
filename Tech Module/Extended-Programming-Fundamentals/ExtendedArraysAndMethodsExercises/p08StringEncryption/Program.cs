using System;

namespace p08StringEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string result = string.Empty;

            for (int i = 0; i < number; i++)
            {
                char currentLetter = char.Parse(Console.ReadLine());

                int num = currentLetter;
                int currentNum = num;

                if (currentLetter >= 'A' && currentLetter <= 'Z' 
                    || currentLetter >= 'a' && currentLetter <= 'c')
                {
                    int lastDigit = num % 10;
                    num /= 10;
                    int firstDigit = num % 10;

                    result += ConvertNumToChar(firstDigit, lastDigit, currentNum);
                }
                else if (currentLetter >= 'd' && currentLetter <= 'z')
                {
                    int lastDigit = num % 10;
                    num /= 10;
                    int middleDigit = num % 10;
                    num /= 10;
                    int firstDigit = num % 10;

                    result += ConvertNumToChar(firstDigit, lastDigit, currentNum);
                }
            }

            Console.WriteLine(result);
        }

        static  string ConvertNumToChar(int firstDigit, int lastDigit, int currentNum)
        {
            string result = string.Empty;

            string total = ($"{firstDigit}{lastDigit}");
            int sum1 = currentNum + lastDigit;
            char letter1 = Convert.ToChar(sum1);
            int sum2 = currentNum - firstDigit;
            char letter2 = Convert.ToChar(sum2);

            result += letter1 + total + letter2;

            return result;
        }
    }
}
