using System;

namespace p05Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int width = num * 4 + 1;
            int height = num * 2 + 1;

            Console.WriteLine(new string('#', width));

            int dies = num * 2 - 1;
            int space = 1;

            for (int i = 1; i <= num; i++)
            {
                if (i == num / 2 + 1)
                {
                    Console.WriteLine("{0}{1}{2}(@){2}{1}{0}",
                    new string('.', i),
                    new string('#', dies),
                    new string(' ', (num / 2) - 1));
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string('.', i),
                    new string('#', dies),
                    new string(' ', space));
                }
                
                dies -= 2;
                space += 2;
            }

            int dots = num + 1;
            dies = num * 2 - 1;

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('.', dots),
                    new string('#', dies));

                dots++;
                dies -= 2;
            }
        }
    }
}
