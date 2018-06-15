using System;

namespace p02PipeInThePool2
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume = double.Parse(Console.ReadLine());
            double pipe1 = double.Parse(Console.ReadLine());
            double pipe2 = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            pipe1 *= hours;
            pipe2 *= hours;
            double total = pipe1 + pipe2;

            if (total <= volume)
            {
                double result = Math.Truncate(total * 100 / volume);
                double resultPipe1 = pipe1 * 100 / total;
                double resultPipe2 = pipe2 * 100 / total;

                Console.WriteLine(
                    $"The pool is {result}% full. Pipe 1: {Math.Truncate(resultPipe1)}%." +
                    $" Pipe 2: {Math.Truncate(resultPipe2)}%.");
            }
            else if (total > volume)
            {
                total -= volume;

                Console.WriteLine(
                    $"For {hours} hours the pool overflows with {total:F1} liters.");
            }
        }
    }
}
