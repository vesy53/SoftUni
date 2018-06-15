using System;

namespace p04Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDays = int.Parse(Console.ReadLine());
            double kmFirstDay = double.Parse(Console.ReadLine());

            double total = kmFirstDay;

            for (int i = 0; i < numDays; i++)
            {
                double percentage = double.Parse(Console.ReadLine());
            
                double sumPercent = percentage / 100;
                kmFirstDay += kmFirstDay * sumPercent;
                total += kmFirstDay;
            }

            if (total <= 1000)
            {
                double result = Math.Ceiling(1000 - total);

                Console.WriteLine(
                    $"Sorry Mrs. Ivanova, you need to run {result} more kilometers");
            }
            else if (total > 1000)
            {
                total = Math.Ceiling(total - 1000);

                Console.WriteLine(
                    $"You've done a great job running {total} more kilometers!");
            }
        }
    }
}
