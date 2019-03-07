using System;

namespace p06CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();

            int num = int.Parse(Console.ReadLine());
            long maxNum = long.MinValue;

            for (int i = 0; i < num; i++)
            {
                long countsIds = long.Parse(Console.ReadLine());

                if (numeralType == "sbyte" && 
                    (countsIds > sbyte.MinValue && countsIds <= sbyte.MaxValue))
                {
                    if (countsIds > maxNum)
                    {
                        maxNum = countsIds;
                    }
                }
                else if (numeralType == "int" && 
                    (countsIds >= int.MinValue && countsIds <= int.MaxValue))
                {
                    if (countsIds > maxNum)
                    {
                        maxNum = countsIds;
                    }
                }
                else if (numeralType == "long" && 
                    (countsIds >= long.MinValue && countsIds <= long.MaxValue))
                {
                    if (countsIds > maxNum)
                    {
                        maxNum = countsIds;
                    }
                }
            }

            Console.WriteLine(maxNum);
        }
    }
}
