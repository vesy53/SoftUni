using System;

namespace p02WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double recordInM = double.Parse(Console.ReadLine());
            double timeInSec1M = double.Parse(Console.ReadLine());

            double result = recordInM * timeInSec1M;
            double totalTime = Math.Floor(recordInM / 15) * 12.5;
            double total = result + totalTime;

            if (recordInSec <= total)
            {
                total -= recordInSec;

                Console.WriteLine(
                    $"No, he failed! He was {total:f2} seconds slower.");
            }
            else if (recordInSec > total)
            {
                Console.WriteLine(
                    $"Yes, he succeeded! The new world record is {total:F2} seconds.");
            }
        }
    }
}
