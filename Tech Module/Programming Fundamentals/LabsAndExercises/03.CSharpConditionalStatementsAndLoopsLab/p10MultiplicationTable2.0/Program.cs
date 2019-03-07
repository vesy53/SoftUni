using System;

namespace p10MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int startNum = int.Parse(Console.ReadLine());

            int multiplication = 0;

            for (int i = startNum; i <= 10; i++)
            {
                multiplication = num * i;

                Console.WriteLine($"{num} X {i} = {multiplication}");
            }

            if (startNum > 10)
            {
                multiplication = num * startNum;

                Console.WriteLine($"{num} X {startNum} = {multiplication}");
            }
        }
    }
}
