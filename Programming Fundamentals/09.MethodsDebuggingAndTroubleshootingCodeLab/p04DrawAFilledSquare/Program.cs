using System;

namespace p04DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintOneLine(num);
            PrintTheBody(num);
            PrintOneLine(num);
        }

        static void PrintOneLine(int num)
        {
            Console.WriteLine(new string('-', num * 2));
        }

        static void PrintTheBody(int num)
        {
            for (int i = 1; i < num - 1; i++)
            {
                Console.Write("-");

                for (int j = 1; j < num; j++)
                {
                    Console.Write("\\/");
                }
                
                Console.WriteLine('-');
            }
        }
    }
}
