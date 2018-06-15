using System;

namespace p04GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double counter1 = 0.0;
            double counter2 = 0.0;
            double counter3 = 0.0;
            double counter4 = 0.0;
            double counter5 = 0.0;
            double counter6 = 0.0;
            double result = 0.0;

            for (int i = 0; i < num; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number >= 0 && number <= 9)
                {
                    counter1++;
                    result += number * 0.2;
                }
                else if (number >= 10 && number <= 19)
                {
                    counter2++;
                    result += number * 0.3;
                }
                else if (number >= 20 && number <= 29)
                {
                    counter3++;
                    result += number * 0.4;
                }
                else if (number >= 30 && number <= 39)
                {
                    counter4++;
                    result += 50;
                }
                else if (number >= 40 && number <= 50)
                {
                    counter5++;
                    result += 100;
                }
                else if (number < 0 || number > 50)
                {
                    counter6++;
                    result /= 2;
                }
            }

            Console.WriteLine($"{result:F2}");
            Console.WriteLine(
                $"From 0 to 9: {counter1 / num * 100:F2}%");
            Console.WriteLine
                ($"From 10 to 19: {counter2 / num * 100:F2}%");
            Console.WriteLine
                ($"From 20 to 29: {counter3 / num * 100:F2}%");
            Console.WriteLine(
                $"From 30 to 39: {counter4 / num * 100:F2}%");
            Console.WriteLine(
                $"From 40 to 50: {counter5 / num * 100:F2}%");
            Console.WriteLine(
                $"Invalid numbers: {counter6 / num * 100:F2}%");
        }
    }
}
