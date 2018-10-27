namespace p06._03.SumBigNumbers
{
    using System;
    using System.Numerics;

    class SumBigNumbers3
    {
        static void Main(string[] args)
        {
            BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
            BigInteger secondNum = BigInteger.Parse(Console.ReadLine());

            BigInteger sum = firstNum + secondNum;

            Console.WriteLine(sum);
        }
    }
}
