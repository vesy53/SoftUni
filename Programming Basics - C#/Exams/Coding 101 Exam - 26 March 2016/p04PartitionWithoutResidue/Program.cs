using System;

namespace p04PartitionWithoutResidue
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double counter1 = 0.0;
            double counter2 = 0.0;
            double counter3 = 0.0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    counter1++;             
                }
                if(number % 3 == 0)
                {
                    counter2++;
                }
                if (number % 4 == 0)
                {
                    counter3++;
                }
            }

            Console.WriteLine($"{counter1 / n * 100:F2}%");
            Console.WriteLine($"{counter2 / n * 100:F2}%");
            Console.WriteLine($"{counter3 / n * 100:F2}%");
        }
    }
}
