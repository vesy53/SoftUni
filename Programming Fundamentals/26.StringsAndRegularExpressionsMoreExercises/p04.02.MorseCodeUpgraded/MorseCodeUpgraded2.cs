namespace p04._02.MorseCodeUpgraded
{
    using System;
    using System.Linq;

    class MorseCodeUpgraded2
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split('|');

            string result = string.Empty;

            foreach (var symbol in input)
            {
                int count0 = symbol.Count(x => x == '0');
                int count1 = symbol.Count(x => x == '1');

                int sum = count0 * 3 + count1 * 5;

                int count = 1;

                for (int i = 1; i < symbol.Length; i++)
                {
                    if (symbol[i - 1] == symbol[i])
                    {
                        count++;
                    }
                    else
                    {
                        if (count == 1)
                        {
                            continue;
                        }

                        sum += count;
                        count = 1;
                    }

                    if (i == symbol.Length - 1 && count != 1)
                    {
                        sum += count;
                    }
                }

                result += Convert.ToChar(sum);
            }

            Console.WriteLine(result);
        }
    }
}
