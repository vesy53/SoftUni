namespace p01._01.SquareRoot
{
    using System;

    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new ArgumentException("Invalid number");
                }

                int squareRoot = (int)Math.Sqrt(number);

                Console.WriteLine(squareRoot);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
