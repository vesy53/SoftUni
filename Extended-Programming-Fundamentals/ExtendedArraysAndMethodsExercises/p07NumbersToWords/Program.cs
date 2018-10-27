using System;

namespace p07NumbersToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string nameDigit = string.Empty;

            for (int i = 0; i < number; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num > 999)
                {
                    nameDigit = "too large";
                }
                else if (num < -999)
                {
                    nameDigit = "too small";
                }
                else if (num >= 100 && num <= 999)
                {
                    nameDigit = TakePositiveNum(num, nameDigit);
                }
                else if (num >= -999 && num <= -100)
                {
                    nameDigit = "minus ";
                    num = Math.Abs(num);

                    nameDigit = TakePositiveNum(num, nameDigit);
                }

                Console.WriteLine(nameDigit);

                nameDigit = string.Empty;
            }
        }

        static string TakePositiveNum(int num, string nameDigit)
        {
            if (num >= 100 && num <= 999)
            {
                int lastDigit = num % 100;
                num /= 100;
                int firstDigit = num % 100;

                nameDigit = NumInWordsToHundred(num, firstDigit, nameDigit) + "-hundred";

                if (lastDigit > 0 && lastDigit < 10)
                {
                    nameDigit += " and ";
                    nameDigit = NumInWordsToHundred(num, lastDigit, nameDigit);
                }
                else if (lastDigit >= 10 && lastDigit <= 19)
                {
                    nameDigit += " and ";
                    nameDigit = NumInWordsFrom10To19(num, lastDigit, nameDigit);
                }

                int lastDigit2 = lastDigit % 10;
                lastDigit /= 10;
                int lastDigit1 = lastDigit % 10;

                if (lastDigit1 >= 2 && lastDigit1 <= 9)
                {
                    nameDigit = NumInWordsInTens(num, lastDigit1, nameDigit);

                    if (lastDigit2 > 0 && lastDigit2 < 10)
                    {
                        nameDigit += " ";
                        nameDigit = NumInWordsToHundred(num, lastDigit2, nameDigit);
                    }
                }
            }

            return nameDigit;
        }

        static string NumInWordsInTens(int num, int lastDigit1, string nameDigit)
        {
            switch (lastDigit1)
            {
                case 2:
                    nameDigit += " and twenty";
                    break;
                case 3:
                    nameDigit += " and thirty";
                    break;
                case 4:
                    nameDigit += " and forty";
                    break;
                case 5:
                    nameDigit += " and fifty";
                    break;
                case 6:
                    nameDigit += " and sixty";
                    break;
                case 7:
                    nameDigit += " and seventy";
                    break;
                case 8:
                    nameDigit += " and eighty";
                    break;
                case 9:
                    nameDigit += " and ninety";
                    break;
            }

            return nameDigit;
        }

        static string NumInWordsFrom10To19(int num, int lastDigit, string nameDigit)
        {
            switch (lastDigit)
            {
                case 10:
                    nameDigit += "ten";
                    break;
                case 11:
                    nameDigit += "eleven";
                    break;
                case 12:
                    nameDigit += "twelve";
                    break;
                case 13:
                    nameDigit += "thirteen";
                    break;
                case 14:
                    nameDigit += "fourteen";
                    break;
                case 15:
                    nameDigit += "fifteen";
                    break;
                case 16:
                    nameDigit += "sixteen";
                    break;
                case 17:
                    nameDigit += "seventeen";
                    break;
                case 18:
                    nameDigit += "eighteen";
                    break;
                case 19:
                    nameDigit += "nineteen";
                    break;
            }

            return nameDigit;
        }

        static string NumInWordsToHundred(int num, int firstDigit, string nameDigit)
        {           
            switch (firstDigit)
            {
                case 1:
                    nameDigit += "one";
                    break;
                case 2:
                    nameDigit += "two";
                    break;
                case 3:
                    nameDigit += "three";
                    break;
                case 4:
                    nameDigit += "four";
                    break;
                case 5:
                    nameDigit += "fife";
                    break;
                case 6:
                    nameDigit += "six";
                    break;
                case 7:
                    nameDigit += "seven";
                    break;
                case 8:
                    nameDigit += "eight";
                    break;
                case 9:
                    nameDigit += "nine";
                    break;
            }

            return nameDigit;
        }
    }
}
