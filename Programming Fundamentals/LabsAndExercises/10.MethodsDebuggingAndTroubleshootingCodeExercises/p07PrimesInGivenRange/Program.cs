using System;
using System.Collections.Generic;

namespace p07PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            List<int> findPrimesNum = FindPrimesInRange(startNum, endNum);

            Console.WriteLine(string.Join(", ", findPrimesNum));
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> findPrimesNum = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                int number = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        number++;
                        break;
                    }
                }

                if (number == 0 && i != 0 && i != 1)
                {
                    findPrimesNum.Add(i);
                }
            }

            return findPrimesNum;
        }
    }
}
