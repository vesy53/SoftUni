namespace p01._01.Snowballs
{
    using System;
    using System.Numerics;

    class Snowballs
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            BigInteger maxSum = 0;
            long maxSnow = 0;
            long maxTime = 0;
            long maxQuality = 0;

            for (int i = 0; i < num; i++)
            {
                long snow = long.Parse(Console.ReadLine());
                long time = long.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger power = BigInteger.Pow((snow / time), quality);

                if (power > maxSum)
                {
                    maxSum = power;
                    maxSnow = snow;
                    maxTime = time;
                    maxQuality = quality;
                }
            }

            Console.WriteLine(
                $"{maxSnow} : {maxTime} = {maxSum} ({maxQuality})");
        }
    }
}
