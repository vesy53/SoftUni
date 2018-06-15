using System;

namespace p05Ladybird1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int width = num * 2 + 1;

            Console.WriteLine("{0}@   @", 
                new string(' ', width / 2 - 2));

            Console.WriteLine("{0}\\_/",
                new string(' ', width / 2 - 1));

            Console.WriteLine("{0}/ \\",
                new string(' ', width / 2 - 1));

            Console.WriteLine("{0}|_|",
                new string(' ', width / 2 - 1));

            int space = width / 2 - 1;

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("{0}/{1}|{1}\\",
                    new string(' ', space),
                    new string(' ' , i));

                space--; 
            }

            for (int i = 0; i < num / 2; i++)
            {
                Console.WriteLine("|{0}@{1}|{1}@{0}|",
                    new string(' ', num / 2 - 1),
                    new string(' ', (num + 1) / 2 - 1));
            }

            if (num == 2)
            {
                space = width / 2 - 1;
                for (int i = 0; i < num / 2 - 1; i++)
                {
                    Console.WriteLine("{0}\\{1}|{1}/",
                        new string(' ', i),
                        new string(' ', space));

                    space--;
                }
            }
            else if (num > 2)
            {
                space = width / 2 - 1;

                for (int i = 0; i < num / 2; i++)
                {
                    Console.WriteLine("{0}\\{1}|{1}/",
                        new string(' ', i),
                        new string(' ', space));

                    space--;
                }
            }

            if (num % 2 == 0)
            {
                Console.WriteLine("{0}{1}|{1}{0}",
                    new string(' ', num / 2),
                    new string('^', num / 2));
            }
            else if (num % 2 == 1)
            {
                Console.WriteLine("{0}{1}|{1}{0}",
                   new string(' ', num / 2 + 1),
                   new string('^', num / 2));
            }           
        }
    }
}
