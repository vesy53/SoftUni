namespace Operations
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            IMathOperations mathOperations = new MathOperations();

            Console.WriteLine(mathOperations.Add(2, 3));
            Console.WriteLine(mathOperations.Add(2.2, 3.3, 5.5));
            Console.WriteLine(mathOperations.Add(2.2M, 3.3M, 4.4M));
        }
    }
}
