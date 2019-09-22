namespace p05._03.ConvertToDouble
{
    using System;

    class ConvertToDouble
    {
        public static void Main(string[] args)
        {
            try
            {
                double number = ReadDouble();

                Console.WriteLine(number);
            }
            catch (Exception ex)  // this is NOT a good practice
              when (ex is FormatException || // with WHEN - we will only capture these 2 types of exceptions
                    ex is OverflowException)
            {
            }
        }

        private static double ReadDouble()
        {
            try
            {
                string input = Console.ReadLine();

                double number = Convert.ToDouble(input);

                return number;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}
