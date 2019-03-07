using System;
using System.Numerics;

class BigFactorial2
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        BigInteger factorial = 1;

        for (int i = num; i >= 1; i--)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);
    }
}

