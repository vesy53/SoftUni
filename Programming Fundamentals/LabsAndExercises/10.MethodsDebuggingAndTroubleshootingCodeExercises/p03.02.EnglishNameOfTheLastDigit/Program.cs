using System;
using System.Collections.Generic;

namespace p03EnglishNameOfTheLastDigit1
{//100/100
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            num = Math.Abs(num);

            EnglishNameOfTheLastDigit1(num);           
        }

        static void EnglishNameOfTheLastDigit1(long num)
        {
            long lastDigit = num % 10;

            Dictionary<long, string> nameDigit = new Dictionary<long, string>
            {
                [0] = "zero",
                [1] = "one",
                [2] = "two",
                [3] = "three",
                [4] = "four",
                [5] = "five",
                [6] = "six",
                [7] = "seven",
                [8] = "eight",
                [9] = "nine"
            };

            Console.WriteLine(nameDigit[lastDigit]);
        }
    }
}
