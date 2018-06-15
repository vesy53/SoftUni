using System;

namespace p06RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', n - row));

                for (int i = 0; i < row; i++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(new string(' ', n - i));

                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}
