using System;

namespace p07LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < number; i++)
            {
                int num = int.Parse(Console.ReadLine());

                leftSum += num;
            }

            for (int i = 0; i < number; i++)
            {
                int num = int.Parse(Console.ReadLine());

                rightSum += num;
            }

            int dif = Math.Abs(leftSum - rightSum);

            if (dif == 0)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {dif}");
            }
        }
    }
}
