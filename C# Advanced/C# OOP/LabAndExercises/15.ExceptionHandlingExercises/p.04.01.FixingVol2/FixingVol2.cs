namespace p04._01.FixingVol2
{
    using System;

    class FixingVol2
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please, enter first number: ");

                int firstNumber = int.Parse(Console.ReadLine());

                Console.Write("Please, enter second number: ");

                int secondNumber = int.Parse(Console.ReadLine());

                byte result = Convert
                    .ToByte(firstNumber * secondNumber);

                Console.WriteLine("The result is:");

                Console.WriteLine(
                    $"{firstNumber} x {secondNumber} = {result}");
            }
            //catch (OverflowException oe)
            //{
            //    Console.WriteLine(oe.Message);
            //}
            catch (OverflowException)
            {
                Console.WriteLine(
                    $"The result is outside of the range of a Byte.");
            }
        }
    }
}
