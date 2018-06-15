using System;

namespace p05Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int width = num * 4 - 4;
            int space = width - 4;

            for (int i = 0; i < num - 2; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*\\");
                }

                Console.Write(new string(' ' , space));
                space -= 4;

                for (int k = 0; k <= i; k++)
                {
                    Console.Write("/*");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < width / 2; j++)
                {
                    Console.Write("\\/");
                }
            }
            Console.WriteLine();

            for (int i = 0; i < num / 2; i++)
            {
                Console.WriteLine("{0}*|**|*{1}",
                    new string('<', width / 2 - 3),
                    new string('>', width / 2 - 3));
            }

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < width / 2; j++)
                {
                    Console.Write("/\\");
                }
            }
            Console.WriteLine();

            space = 4;

            for (int i = num - 2; i >= 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*/");
                }
                Console.Write(new string(' ', space));
                space += 4;

                for (int k = i; k > 0; k--)
                {
                    Console.Write("\\*");
                }
                Console.WriteLine();
            }
        }
    }
}
