using System;
using System.Collections.Generic;
using System.Linq;

namespace p01MaxSequenceOfEqualElements1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int counter = 1;
            int counterMax = 0;
            int maxNum = 0;

            for (int i = 0; i < number.Count - 1; i++)
            {
                if (number[i] == number[i + 1])
                {
                    counter++;

                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        maxNum = number[i];
                    }
                }
                else
                {
                    counter = 1;

                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        maxNum = number[i];
                    }
                }
            }

            for (int i = 0; i < counterMax; i++)
            {
                Console.Write(maxNum + " ");
            }

            Console.WriteLine();
        }
    }
}
