using System;

namespace p05BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            double BPM = double.Parse(Console.ReadLine());
            int beats = int.Parse(Console.ReadLine());

            double bars = beats / 4.0;

            int sum = (int)((beats / BPM) * 60);
            int minutes = sum / 60;
            int seconds = sum % 60;

            Console.WriteLine
                ($"{Math.Round(bars, 1)} bars - {minutes}m {seconds}s");
        }
    }
}
