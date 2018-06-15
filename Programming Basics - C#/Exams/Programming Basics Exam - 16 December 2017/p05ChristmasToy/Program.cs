using System;

namespace p05ChristmasToy
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int width = num * 5;
            int height = num * 2 + 3;

            Console.WriteLine("{0}{1}{0}", 
                new string('-', num * 2),
                new string('*', num));

            int dash = num * 2 - 2;
            int symbol = num + 2;

            for (int i = 1; i <= num / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string('-', dash),
                    new string('*', i),
                    new string('&', symbol));

                dash -= 2;
                symbol += 2;
            }

            dash = num - 1;
            int sortDash = num * 3 - 2;

            for (int i = 0; i < num / 2; i++)
            {
                Console.WriteLine("{0}**{1}**{0}",
                    new string('-', dash),
                    new string('~', sortDash));

                dash--;
                sortDash += 2;
            }

            Console.WriteLine("{0}*{1}*{0}",
                new string('-', num / 2),
                new string('|', num * 4 - 2));

            dash = num / 2;
            sortDash = num * 4 - 4;

            for (int i = 1; i <= num / 2; i++)
            {
                Console.WriteLine("{0}**{1}**{0}",
                    new string('-',dash),
                    new string('~', sortDash));

                dash++;
                sortDash -= 2;
            }

            dash = num;
            int stars = num / 2;
            symbol = num * 2;

            for (int i = 0; i < num / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string('-', dash),
                    new string('*', stars),
                    new string('&', symbol));

                dash += 2;
                stars--;
                symbol -= 2;
            }

            Console.WriteLine("{0}{1}{0}",
                new string('-', num * 2),
                new string('*', num));
        }
    }
}
