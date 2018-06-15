using System;

namespace p02PipesInThePool
{
    class Program
    {
        static void Main(string[] args)
        {
            double poolVolumeInLiters = double.Parse(Console.ReadLine());
            double pipe1 = double.Parse(Console.ReadLine());
            double pipe2 = double.Parse(Console.ReadLine());
            double hour = double.Parse(Console.ReadLine());

            double resultPipe1 = pipe1 * hour;
            double resultPipe2 = pipe2 * hour;
            double total = resultPipe1 + resultPipe2;

            if (total <= poolVolumeInLiters)
            {
                double totalResult = Math.Truncate(total * 100 / poolVolumeInLiters);
                double totalPip1 = Math.Truncate(resultPipe1 * 100 / total);
                double totalPip2 = Math.Truncate(resultPipe2 * 100 / total);

                Console.WriteLine(
                    $"The pool is {totalResult}% full. Pipe 1: {totalPip1}%. Pipe 2: {totalPip2}%.");
            }
            else if(total > poolVolumeInLiters)
            {
                total -= poolVolumeInLiters;

                Console.WriteLine(
                    $"For {hour} hours the pool overflows with {total:F1} liters.");
            }
        }
    }
}
