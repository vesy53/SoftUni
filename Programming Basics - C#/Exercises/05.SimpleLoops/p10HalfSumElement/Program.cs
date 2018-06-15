using System;

namespace p10HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < number; i++)
            {
                int num = int.Parse(Console.ReadLine());
                             
                if (num > max)
                {
                    max = num;                  
                }

                sum += num;
            }

            sum -= max;

            if (sum == max)
            {
                Console.WriteLine($"Yes\r\nSum = {max}");
            }
            else
            {
                Console.WriteLine($"No\r\nDiff = {Math.Abs(max-sum)}");
            }
        }
    }
}
