using System;

namespace p15ThreeEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());

             if (firstNum == secondNum && firstNum == thirdNum 
                 && secondNum == thirdNum)
             {
                 Console.WriteLine("yes");
             }
             else
             {
                 Console.WriteLine("no");
             }
        }
    }
}
