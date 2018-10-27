namespace p04._01.MorseCodeUpgraded
{
    using System;

    class MorseCodeUpgraded
    {
        static void Main(string[] args)
        {
            string[] inputNums = Console.ReadLine()
                .Split('|');

            string result = string.Empty;
            int sum = 0;           

            for (int i = 0; i < inputNums.Length; i++)
            {
                string currentStr = inputNums[i];
                int count1 = 0;
                int count0 = 0;

                for (int j = 0; j < currentStr.Length; j++)
                {
                    if (currentStr[j] == '1')
                    {
                        count1++;
                    }
                    else if (currentStr[j] == '0')
                    {
                        count0++;
                    }
                }

                sum = count0 * 3 + count1 * 5;
                int count = 1;

                for (int j = 1; j < currentStr.Length; j++)
                {
                    if (currentStr[j - 1] == currentStr[j])
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

                    if (j == currentStr.Length - 1 && count != 1)
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
