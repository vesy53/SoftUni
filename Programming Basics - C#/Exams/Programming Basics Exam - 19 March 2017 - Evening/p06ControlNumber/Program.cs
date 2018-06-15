using System;

namespace p06ControlNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int controlNum = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;

            for (int i = 1; i <= num1; i++)
            {
                for (int j = num2; j >= 1; j--)
                {
                    counter++;
                    sum += i * 2 + j * 3;

                    if (sum >= controlNum)
                    {
                        Console.WriteLine($"{counter} moves\r\n" +
                            $"Score: {sum} >= {controlNum}");
                        break;
                    }
                }

                if (sum >= controlNum)
                {
                    break;
                }
            }

            if (sum < controlNum)
            {
                Console.WriteLine($"{counter} moves");
            }
        }
    }
}
