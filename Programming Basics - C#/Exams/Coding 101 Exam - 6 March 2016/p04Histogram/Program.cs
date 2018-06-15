using System;

namespace p04Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double number  = double.Parse(Console.ReadLine());

            double counter1 = 0.0;
            double counter2 = 0.0;
            double counter3 = 0.0;
            double counter4 = 0.0;
            double counter5 = 0.0;

            for (int i = 1; i <= number; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    counter1++;
                }
                else if (num >= 200 && num <= 399)
                {
                    counter2++;
                }
                else if (num >= 400 && num <= 599)
                {
                    counter3++;
                }
                else if (num >= 600 && num <= 799)
                {
                    counter4++;
                }
                else if (num >= 800)
                {
                    counter5++;
                }
            }

            Console.WriteLine($"{counter1 / number * 100:F2}%");
            Console.WriteLine($"{counter2 / number * 100:F2}%");
            Console.WriteLine($"{counter3 / number * 100:F2}%");
            Console.WriteLine($"{counter4 / number * 100:F2}%");
            Console.WriteLine($"{counter5 / number * 100:F2}%");
        }
    }
}
