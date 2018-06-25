using System;

namespace p12TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int multiply = 0;
            int counter = 0;
            int sum = 0;

            for (int i = num1; i >= 1; i--)
            {
                for (int j = 1; j <= num2; j++)
                {
                    counter++;
                    multiply = 3 * (i * j);
                    sum += multiply;

                    if (sum >= maxSum)
                    {
                        break;
                    }
                }

                if (sum >= maxSum)
                {
                    break;
                }
            }

            Console.WriteLine($"{counter} combinations");

            if (sum >= maxSum)
            {
                Console.WriteLine($"Sum: {sum} >= {maxSum}");
            }
            else if (sum < maxSum)
            {
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
