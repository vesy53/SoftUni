namespace p02._01.EnterNumbers
{
    using System;

    class EnterNumbers
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    ReadNumber(1, 100);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    i = -1;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                    i = -1;
                }
            }
        }

        private static void ReadNumber(int startNum, int endNum)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < startNum ||
                number > endNum)
            {
                throw new ArgumentException(
                    $"The number should be in the range {startNum} - {endNum}");
            }
        }
    }
}
