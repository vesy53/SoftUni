using System;

namespace p06TwoNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int counter = 0;
            int sum = 0;

            for (int i = start; i >= end; i--)
            {
                for (int j = start; j >= end; j--)
                {
                    counter++;
                    sum = i + j;

                    if (sum == magicNum)
                    {
                        Console.WriteLine(
                            $"Combination N:{counter} ({i} + {j} = {sum})");
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
