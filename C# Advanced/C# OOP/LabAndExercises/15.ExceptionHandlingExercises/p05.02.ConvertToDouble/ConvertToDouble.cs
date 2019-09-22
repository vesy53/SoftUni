namespace p05._02.ConvertToDouble
{
    using System;

    class ConvertToDouble
    {
        public static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();

                double number = Convert.ToDouble(input);

                Console.WriteLine(number);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
        }
    }
}
