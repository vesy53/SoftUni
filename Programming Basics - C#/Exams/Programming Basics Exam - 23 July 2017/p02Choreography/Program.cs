using System;

namespace p02Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            double steps = double.Parse(Console.ReadLine());
            double dancers = double.Parse(Console.ReadLine());
            double daysForLearning = double.Parse(Console.ReadLine());

            double stepsForDay = (steps / daysForLearning) / steps;
            stepsForDay = Math.Ceiling(stepsForDay * 100);
            double percentPerDancer = stepsForDay / dancers;

            if (stepsForDay <= 13)
            {
                Console.WriteLine(
                    $"Yes, they will succeed in that goal! {percentPerDancer:F2}%.");
            }
            else if (stepsForDay > 13)
            {
                Console.WriteLine(
                    $"No, They will not succeed in that goal! Required" +
                    $" {percentPerDancer:F2}% steps to be learned per day.");
            }
        }
    }
}
