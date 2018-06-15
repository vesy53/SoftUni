using System;

namespace p06Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int number = num;
            int digit3 = num % 10;
            num /= 10;
            int digit2 = num % 10;
            num /= 10;
            int digit1 = num % 10;

            for (int i = 1; i <= digit1 + digit2; i++)
            {
                for (int j = 1; j <= digit1 + digit3; j++)
                {              
                    if (number % 5 == 0)
                    {
                        number -= digit1;
                    }
                    else if (number % 3 == 0)
                    {
                        number -= digit2;
                    }
                    else
                    {
                        number += digit3;
                    }
                    Console.Write($"{number} ");
                }

                Console.WriteLine();
            }
        }
    }
}
