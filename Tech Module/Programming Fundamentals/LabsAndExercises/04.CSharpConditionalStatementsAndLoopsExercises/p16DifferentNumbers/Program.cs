using System;

namespace p115DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num2 - num1 < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = num1; i < num2; i++)
                {
                    for (int j = num1; j <= num2; j++)
                    {
                        for (int k = num1; k <= num2; k++)
                        {
                            for (int l = num1; l <= num2; l++)
                            {
                                for (int m = num1; m <= num2; m++)
                                {
                                    if (i < j && j < k && k < l && l < m)
                                    {
                                         Console.WriteLine($"{i} {j} {k} {l} {m} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
