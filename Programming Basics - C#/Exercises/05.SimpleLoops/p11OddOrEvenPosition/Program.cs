using System;

namespace p11OddOrEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= number; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 1)
                {
                    oddSum += num;

                    if (num < oddMin)
                    {
                        oddMin = num;
                    }

                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                }
                else if (i % 2 == 0)
                {
                    evenSum += num;

                    if (num < evenMin)
                    {
                        evenMin = num;
                    }

                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                }                            
            }

            Console.WriteLine($"OddSum={oddSum},");

            if (!(oddMin == double.MaxValue))
            {
                Console.WriteLine($"OddMin={oddMin},");
            }
            else
            {
                Console.WriteLine("OddMin=No,");
            }

            if (!(oddMax == double.MinValue))
            {
                Console.WriteLine($"OddMax={oddMax},");
            }
            else
            {
                Console.WriteLine("OddMax=No,");

            }

            Console.WriteLine($"EvenSum={evenSum},");

            if (!(evenMin == double.MaxValue))
            {
                Console.WriteLine($"EvenMin={evenMin},");
            }
            else
            {
                Console.WriteLine("EvenMin=No,");
            }

            if (!(evenMax == double.MinValue))
            {
                Console.WriteLine($"EvenMax={evenMax}");
            }
            else
            {
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
 