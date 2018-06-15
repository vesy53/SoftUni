using System;

namespace p03Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstSide = double.Parse(Console.ReadLine());
            double secSide = double.Parse(Console.ReadLine());
            double thirdSide = double.Parse(Console.ReadLine());

            if (firstSide < secSide + thirdSide && secSide < firstSide + thirdSide
                && thirdSide < firstSide + secSide)
            {
                if (firstSide != secSide && secSide != thirdSide && firstSide != thirdSide)
                {
                    Console.WriteLine(
                        $"Triangle with sides {firstSide}, {secSide} and {thirdSide} is scalene.");
                }
                else if (firstSide == secSide && secSide == thirdSide)
                {
                    Console.WriteLine(
                        $"Triangle with sides {firstSide}, {secSide} and {thirdSide} is equilateral.");
                }
                else if (firstSide == secSide && secSide != thirdSide && firstSide != thirdSide)
                {
                    Console.WriteLine(
                        $"Triangle with sides {firstSide}, {secSide} and {thirdSide} is isosceles.");
                }
                else if (firstSide != secSide && secSide == thirdSide && firstSide != thirdSide)
                {
                    Console.WriteLine(
                        $"Triangle with sides {firstSide}, {secSide} and {thirdSide} is isosceles.");
                }
                else if (firstSide == thirdSide && secSide != firstSide && secSide != thirdSide)
                {
                    Console.WriteLine(
                       $"Triangle with sides {firstSide}, {secSide} and {thirdSide} is isosceles.");
                }
            }
            else
            {
                Console.WriteLine(
                    $"There is no triangle with sides {firstSide}, {secSide} and {thirdSide}.");
            }
        }
    }
}
