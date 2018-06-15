using System;

namespace p06StopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2= int.Parse(Console.ReadLine());
            int num3= int.Parse(Console.ReadLine());

            for (int i = num2; i >= num1; i--)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (i == num3)
                    {                       
                        break;
                    }

                    Console.Write($"{i} ");
                }
            }
        }
    }
}
