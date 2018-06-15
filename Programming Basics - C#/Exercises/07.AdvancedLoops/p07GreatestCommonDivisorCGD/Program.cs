using System;

namespace p07GreatestCommonDivisorCGD
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    num1 -= num2;                 
                }
                else
                {
                    num2 -= num1;
                }
            }

            Console.WriteLine(num1);        
        }
    }
}
