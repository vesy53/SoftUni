using System;

namespace p05ChristmasHat
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int width = num * 4 + 1;
            int height = num * 2 + 5;

            Console.WriteLine("{0}/|\\{0}",
                new string('.', width  / 2 - 1));

            Console.WriteLine("{0}\\|/{0}",
               new string('.', width / 2 - 1));

            int dashes = width / 2 - 1;

            for (int i = 0; i < num * 2; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", 
                    new string('.', dashes),
                    new string('-', i));

                dashes--;
            }

            Console.WriteLine(new string('*', width));

            // First method
            for (int i = 0; i < 1; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    if (j % 2 == 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
           
                Console.WriteLine();
            }

            // Second method
            //for (int i = 1; i <= width / 2; i++)
            //{
            //    Console.Write("*.");            
            //}
            //
            //Console.Write('*');
            //Console.WriteLine();

            Console.WriteLine(new string('*', width));
        }
    }
}
