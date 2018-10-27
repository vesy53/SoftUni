using System;

namespace p07SentenceTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            long num = long.Parse(Console.ReadLine());

            double maxNum = double.MinValue;

            for (int i = 0; i < num; i++)
            {
                long countIds = long.Parse(Console.ReadLine());

                if (numeralType == "sbyte" &&
                    (countIds >= sbyte.MinValue && countIds <= sbyte.MaxValue))
                {
                    if (countIds > maxNum)
                    {
                        maxNum = countIds;
                    }
                }
                else if (numeralType == "int" &&
                    (countIds >= int.MinValue && countIds <= int.MaxValue))
                {
                    if (countIds > maxNum)
                    {
                        maxNum = countIds;
                    }
                }
                else if (numeralType == "long" &&
                    (countIds >= long.MinValue && countIds <= long.MaxValue))
                {
                    if (countIds > maxNum)
                    {
                        maxNum = countIds;
                    }
                }
            }
            double sentence = 0.0;

            if (maxNum < 0)
            {
               sentence = Math.Ceiling(Math.Abs(maxNum / 128));
            }
            else if (maxNum >= 0)
            {
               sentence = Math.Ceiling(maxNum / 127);
            }
          
            if (sentence == 1)
            {
                Console.WriteLine(
                    $"Prisoner with id {maxNum} is sentenced to {sentence} year");
            }
            else
            {
                Console.WriteLine(
                    $"Prisoner with id {maxNum} is sentenced to {sentence} years");
            }
        }
    }
}
