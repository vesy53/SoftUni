using System;

namespace p06MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int digit1 = num / 100 % 10;
            int digit2 = num / 10 % 10;
            int digit3 = num % 10;

            for (int i = 1; i <= digit3; i++)
            {
                for (int j = 1; j <= digit2; j++)
                {
                    for (int k = 1; k <= digit1; k++)
                    {
                        int multiplication = i * j * k;

                        Console.WriteLine($"{i} * {j} * {k} = {multiplication};");
                    }
                }
            }
        }
    }
}
