using System;

namespace p03EnglishNameOfTheLastDigit
{//100/100
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            string result = EnglishNameOfTheLastDigit(num);

            Console.WriteLine(result);
        }

        static string EnglishNameOfTheLastDigit(long num)
        {
            num = Math.Abs(num);
            string last = "";
            long lastDigit = num % 10;

            switch (lastDigit)
            {
                case 0:
                    last = "zero";
                    break;
                case 1:
                    last = "one";
                    break;
                case 2:
                    last = "two";
                    break;
                case 3:
                    last = "three";
                    break;
                case 4:
                    last = "four";
                    break;
                case 5:
                    last = "five";
                    break;
                case 6:
                    last = "six";
                    break;
                case 7:
                    last = "seven";
                    break;
                case 8:
                    last = "eight";
                    break;
                case 9:
                    last = "nine";
                    break;
            }

            return last;
        }
    }
}
