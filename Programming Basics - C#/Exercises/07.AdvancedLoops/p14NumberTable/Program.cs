using System;

namespace p14NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int number = 0;

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    number = i + j + 1;

                    if (number > num)
                    {
                        number -= 2 * num;
                    }

                    Console.Write(Math.Abs(number) + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
