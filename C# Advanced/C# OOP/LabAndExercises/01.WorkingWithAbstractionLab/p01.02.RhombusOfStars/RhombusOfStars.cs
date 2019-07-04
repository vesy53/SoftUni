namespace p01._02.RhombusOfStars
{
    using System;

    class RhombusOfStars
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int spaces = size - 1;
            int stars = 1;

            for (int i = 1; i <= size; i++)
            {
                PrintRow(spaces, stars);

                spaces--;
                stars++;
            }

            spaces = 1;
            stars = size - 1;

            for (int i = size - 1; i > 0; i--)
            {
                PrintRow(spaces, stars);

                spaces++;
                stars--;
            }
        }

        static void PrintRow(int spaces, int stars)
        {
            Console.Write(new string(' ', spaces));

            for (int col = 1; col < stars; col++)
            {
                Console.Write("* ");
            }

            Console.WriteLine("*");
        }
    }
}