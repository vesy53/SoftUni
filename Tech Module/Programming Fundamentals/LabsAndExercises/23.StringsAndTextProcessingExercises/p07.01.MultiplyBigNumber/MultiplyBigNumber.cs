namespace p07._01.MultiplyBigNumber
{
    using System;
    using System.Text;

    class MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            string firstNumStr = Console.ReadLine().TrimStart('0');
            string secondNumStr = Console.ReadLine();

            if (firstNumStr == "0" || secondNumStr == "0")
            {
                Console.WriteLine("0");
                return;
            }

            StringBuilder builder = new StringBuilder();
            int remainder = 0;
            int helper = 0;

            for (int i = firstNumStr.Length - 1; i >= 0; i--)
            {
                int firstNum = int.Parse(firstNumStr[i].ToString());
                int secondNum = int.Parse(secondNumStr.ToString());

                int multiply = (firstNum * secondNum) + helper;

                helper = multiply / 10;
                remainder = multiply % 10;

                builder.Insert(0, remainder.ToString());

                if (i == 0 && helper != 0)
                {
                    builder.Insert(0, helper.ToString());
                }
            }

            Console.WriteLine(builder.ToString().TrimStart('0'));
        }
    }
}
