using System;

namespace p06BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int digit1 = num1 / 1000 % 10;
            int digit2 = num1 / 100 % 10;
            int digit3 = num1 / 10 % 10;
            int digit4 = num1 % 10;
            int dig1 = num2 / 1000 % 10;
            int dig2 = num2 / 100 % 10;
            int dig3 = num2 / 10 % 10;
            int dig4 = num2 % 10;

            for (int i = digit1; i <= dig1; i++)
            {
                for (int j = digit2; j <= dig2; j++)
                {
                    for (int k = digit3; k <= dig3; k++)
                    {
                        for (int m = digit4; m <= dig4; m++)
                        {
                            if (i % 2 == 1 && j % 2 == 1 
                                && k % 2 == 1 && m % 2 == 1)
                            {
                                Console.Write($"{i}{j}{k}{m} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
