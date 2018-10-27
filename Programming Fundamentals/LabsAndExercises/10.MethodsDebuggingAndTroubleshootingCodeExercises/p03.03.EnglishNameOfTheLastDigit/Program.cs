using System;

namespace p03EnglishNameOfTheLastDigit2
{
    class Program
    {//100/100
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            string[] numName =
            {
                "zero",
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eidht",
                "nine"
            };

            Console.WriteLine(
                numName[int.Parse(num[num.Length - 1].ToString())]);          
        }
    }
}
