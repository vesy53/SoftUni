using System;

namespace p02MinMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());

            double min = FindMinNum(
                FindMinNum(firstNum, secondNum), FindMinNum(secondNum, thirdNum));

            Console.WriteLine(min);
        }

        static double FindMinNum(double firstNum, double secondNum)
        {
            if (firstNum < secondNum)
            {
                return firstNum;
            }

            return secondNum;
        }
    }
}
