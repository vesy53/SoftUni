namespace p06._01.SumBigNumbers
{
    using System;
    using System.Collections.Generic;

    class SumBigNumbers
    {
        static void Main(string[] args)
        {
            string firstStr = Console.ReadLine();
            string secondStr = Console.ReadLine();

            if (firstStr.Length > secondStr.Length)
            {
                secondStr = secondStr.PadLeft(firstStr.Length, '0');
            }
            else
            {
                firstStr = firstStr.PadLeft(secondStr.Length, '0');
            }

            List<int> result = new List<int>();

            int reminder = 0;

            for (int i = firstStr.Length - 1; i >= 0; i--)
            {
                int sum = 0;

                int firstNum = firstStr[i] - 48;
                int secondNum = secondStr[i] - 48;

                sum = firstNum + secondNum + reminder;

                result.Add(sum % 10);

                reminder = sum / 10;

                if (i == 0 && reminder > 0)
                {
                    result.Add(reminder);
                }
            }

            result.Reverse();

            string print = string.Join("", result);
            
            Console.WriteLine(print.TrimStart('0'));
        }
    }
}
