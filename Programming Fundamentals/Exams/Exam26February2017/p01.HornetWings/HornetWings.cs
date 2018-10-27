namespace p01.HornetWings
{
    using System;

    class HornetWings
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double totalDistance = (wingFlaps / 1000) * distance;
            int hornetFlaps = wingFlaps / 100;
            int rests = (wingFlaps / endurance) * 5;
            int totalFlaps = hornetFlaps + rests;

            Console.WriteLine($"{totalDistance:F2} m.");
            Console.WriteLine($"{totalFlaps} s.");
        }
    }
}
