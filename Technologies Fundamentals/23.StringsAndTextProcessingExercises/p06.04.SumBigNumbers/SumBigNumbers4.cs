namespace p06._04.SumBigNumbers
{
    using System;
    using System.Linq;
    using System.Text;

    class SumBigNumbers4
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();

            if (firstNum.Length > secondNum.Length)
            {
                secondNum = secondNum.PadLeft(firstNum.Length, '0');
            }
            else
            {
                firstNum = firstNum.PadLeft(secondNum.Length, '0');
            }

            int sum = 0;
            int reminder = 0;
            int num = 0;
            StringBuilder builder = new StringBuilder();

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                sum = firstNum[i] - 48 + secondNum[i] - 48 + reminder;
                num = sum % 10;

                if (sum > 9)
                {
                    reminder = 1;
                }
                else
                {
                    reminder = 0;
                }

                builder.Append(num);

                if (i == 0 && reminder == 1)
                {
                    builder.Append(reminder);
                }
            }

            Console.WriteLine(builder.ToString()
                .TrimEnd('0')
                .ToCharArray()
                .Reverse()
                .ToArray());
        }
    }
}
