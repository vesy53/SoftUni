using System;

namespace p06Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int monets1 = int.Parse(Console.ReadLine());
            int monets2 = int.Parse(Console.ReadLine());
            int banknotes5 = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= monets1; i++)
            {
                for (int j = 0; j <= monets2; j++)
                {
                    for (int k = 0; k <= banknotes5; k++)
                    {
                        int result = i * 1 + j * 2 + k * 5;

                        if (sum == result)
                        {
                            Console.WriteLine(
                                $"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }

        }
    }
}
