namespace p01._01.ConvertFromBase10ToBase
{
    using System;
    using System.Linq;
    using System.Numerics;

    class ConvertFromBase10ToBaseN
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            BigInteger baseNum = BigInteger.Parse(input[0]);
            BigInteger base10 = BigInteger.Parse(input[1]);

            BigInteger remainder = 0;
            string result = string.Empty;

            while (base10 > 0)
            {
                remainder = base10 % baseNum;
                result = remainder.ToString() + result;

                base10 /= baseNum;
            }

            Console.WriteLine(result);
        }
    }
}
