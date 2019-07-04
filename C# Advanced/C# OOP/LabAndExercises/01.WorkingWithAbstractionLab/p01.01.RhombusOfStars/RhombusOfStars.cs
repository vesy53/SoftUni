namespace p01._01.RhombusOfStars
{
    using System;

    class RhombusOfStars
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                PrintRow(num, i);
            }

            for (int i = num - 1; i > 0; i--)
            {
                PrintRow(num, i);
            }
        }

        static void PrintRow(int num, int i)
        {
            for (int j = 0; j < num - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k < i; k++)
            {
                Console.Write("* ");
            }

            Console.WriteLine("*");
        }
    }
}
