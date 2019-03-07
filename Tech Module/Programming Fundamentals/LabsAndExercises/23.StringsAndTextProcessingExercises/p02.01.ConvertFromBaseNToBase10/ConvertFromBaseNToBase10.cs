namespace p02._01.ConvertFromBaseNToBase10
{
    using System;
    using System.Numerics;

    class ConvertFromBaseNToBase10
    {
        static void Main(string[] args)
        {
            string[] inputNums = Console.ReadLine()
                .Split();

            BigInteger numBase = BigInteger.Parse(inputNums[0]);
            BigInteger numToConvert = BigInteger.Parse(inputNums[1]);

            BigInteger result = 0;
            BigInteger power = 0;

            while (numToConvert > 0)
            {
                BigInteger lagstDigit = numToConvert % 10;
                BigInteger baseToPower = 1;

                if (power == 0)
                {
                    baseToPower = 1;
                }
                else
                {
                    for (int i = 0; i < power; i++)
                    {
                        baseToPower *= numBase;
                    }
                }

                result += baseToPower * lagstDigit;
                numToConvert /= 10;
                power++;
            }

            Console.WriteLine(result);
        }
    }
}
