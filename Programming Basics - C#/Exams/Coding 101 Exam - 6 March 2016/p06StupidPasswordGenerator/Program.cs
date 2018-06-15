using System;

namespace p06StupidPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = 1; i <=num1; i++)
            {
                for (int j= 1; j <= num1; j++)
                {
                    for (char k = 'a'; k < 'a' + num2; k++)
                    {
                        for (char n = 'a'; n < 'a' + num2; n++)
                        {
                            for (int m = 1; m <= num1; m++)
                            {
                                if (m > i && m > j)
                                {
                                    Console.Write($"{i}{j}{k}{n}{m} ");

                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
