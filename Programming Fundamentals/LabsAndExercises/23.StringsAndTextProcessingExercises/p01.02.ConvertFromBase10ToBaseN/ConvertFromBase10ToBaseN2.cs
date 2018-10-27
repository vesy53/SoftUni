namespace p01._02.ConvertFromBase10ToBaseN
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    class ConvertFromBase10ToBaseN2
    {
        static void Main(string[] args)
        {
            BigInteger[] inputNums = Console.ReadLine()
                .Split()
                .Select(BigInteger.Parse)
                .ToArray();

            BigInteger baseNum = inputNums[0];
            BigInteger numToConvert = inputNums[1];

            List<BigInteger> result = new List<BigInteger>();

            while (numToConvert > 0)
            {
                BigInteger remainder = numToConvert % baseNum;
                result.Add(remainder);

                numToConvert /= baseNum;
            }

            result.Reverse();

            Console.WriteLine(string.Join("", result));
        }
    }
}
