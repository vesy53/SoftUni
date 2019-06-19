namespace p02._01.RecursiveFactorial
{
    using System;

    class RecursiveFactorial
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            long factorial = Factorial(Math.Abs(endNumber));

            Console.WriteLine(factorial);
        }

        static long Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number * Factorial(number - 1);
        }
    }
}
