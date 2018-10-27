using System;

namespace p02MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());

            double maxNum = MaxNumber(firstNum, secondNum, thirdNum);

            Console.WriteLine(maxNum);
        }

        static double MaxNumber(double firstNum, double secondNum, double thirdNum)
        {
            double max1 = FirstMaxNumber(firstNum, secondNum);
            double max2 = SecondMaxNum(firstNum, thirdNum);
            double max3 = ThirdMaxNum(secondNum, thirdNum);

            return Math.Max(Math.Max(max1, max2), max3);
        }

        static double FirstMaxNumber(double firstNum, double secondNum)
        {
            double maxNum = Math.Max(firstNum, secondNum);

            return maxNum;
        }

        static double SecondMaxNum(double firstNum, double thirdNum)
        {
            double maxNum = Math.Max(firstNum, thirdNum);

            return maxNum;
        }

        static double ThirdMaxNum(double secondNum, double thirdNum)
        {
            double maxNum = Math.Max(secondNum, thirdNum);

            return maxNum;
        }
    }
}
