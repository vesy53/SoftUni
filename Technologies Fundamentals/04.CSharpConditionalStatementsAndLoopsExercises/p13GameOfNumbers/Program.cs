using System;

namespace p13GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int counter = 0;
            int sum = 0;

            for (int i = num2; i >= num1; i--)
            {
                for (int j = num2; j >= num1; j--)
                {
                    counter++;
                    sum = i + j;

                    if (sum == magicNum)
                    {
                        Console.WriteLine(
                            $"Number found! {i} + {j} = {magicNum}");
                        break;
                    }
                }

                if (sum == magicNum)
                {
                   break;
                }
            }

            if (sum != magicNum)
            {
                Console.WriteLine(
                    $"{counter} combinations - neither equals {magicNum}");
            }
        }
    }
}
