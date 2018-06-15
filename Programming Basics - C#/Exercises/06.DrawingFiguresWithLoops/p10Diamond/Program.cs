using System;

namespace p10Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int midDash = 1;

            for (int i = 0; i < (n + 1) / 2; i++)
            {
                if (n % 2 == 1)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("{0}*{0}",
                            new string('-', (n / 2) - i));
                    }
                    else
                    {
                        Console.WriteLine("{0}*{1}*{0}",
                            new string('-', (n / 2) - i),
                            new string('-', midDash));

                        midDash += 2;
                    }
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('-', ((n - 1) / 2) - i),
                        new string('-', i * 2));
                }
            }

            int dash = 1;
            midDash = n - 4;
            for (int i = 1; i <= (n / 2) - 1; i++)
            {
                 Console.WriteLine("{0}*{1}*{0}",
                     new string('-', dash),
                     new string('-', midDash));
                 dash++;
                 midDash -= 2;   
            }

            if (n % 2 == 1 && n > 1)
            {
                Console.WriteLine("{0}*{0}", 
                    new string('-', n / 2));
            }
        }
    }
}
