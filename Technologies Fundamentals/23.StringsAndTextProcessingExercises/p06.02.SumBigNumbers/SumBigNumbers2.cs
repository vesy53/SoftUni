namespace p06._02.SumBigNumbers
{
    using System;
    using System.Text;

    class SumBigNumbers2
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

            StringBuilder builder = new StringBuilder();
            int helper = 0;
            int remainder = 0;

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                int current1 = int.Parse(firstNum[i].ToString());
                int current2 = int.Parse(secondNum[i].ToString());

                int result = current1 + current2 + helper;

                helper = result / 10;
                remainder = result % 10;

                builder.Insert(0, remainder.ToString());

                if (i == 0 && helper != 0)
                {
                    builder.Insert(0, helper.ToString());
                }
            }
            
            Console.WriteLine(builder.ToString().TrimStart('0'));

            //без TrimStart('0')        с TrimStart
            //Input   Output             Output
            //02       05                  5
            //03
        }
    }
}
