namespace p02._02.ConvertFromBaseNToBase10
{
    using System;
    using System.Numerics;

    class ConvertFromBaseNToBase10_2
    {
        static void Main(string[] args)
        {

            string[] inputNums = Console.ReadLine()
                .Split();

            int numBase = int.Parse(inputNums[0]);
            string numToConvert = inputNums[1];

            BigInteger sum = new BigInteger();
            int power = numToConvert.Length - 1;

            for (int i = 0; i < numToConvert.Length; i++)
            {
                BigInteger num = BigInteger.Parse(numToConvert[i].ToString());

                sum += BigInteger.Multiply(num, BigInteger.Pow(numBase, power));

                power--;
            }
            
            Console.WriteLine(sum);
        }
    }
}
