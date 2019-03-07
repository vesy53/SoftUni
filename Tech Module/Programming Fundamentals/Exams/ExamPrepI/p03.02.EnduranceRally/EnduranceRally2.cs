namespace p03._02.EnduranceRally
{
    using System;
    using System.Linq;

    class EnduranceRally2
    {
        static void Main(string[] args)
        {
            string[] drivers = Console.ReadLine()
                .Split();
            double[] zones = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            int[] checkpoints = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            foreach (string driver in drivers)
            {
                double fuel = driver[0];
                int zoneReached = 0;

                for (int i = 0; i < zones.Length; i++)
                {
                    if (fuel > zones[i] || checkpoints.Contains(i))
                    {
                        if (checkpoints.Contains(i))
                        {
                            fuel += zones[i];
                        }
                        else
                        {
                            fuel -= zones[i];
                        }

                        zoneReached = i;
                    }
                    else
                    {
                        zoneReached = i;
                        break;
                    }

                    if (zoneReached == zones.Length - 1)
                    {
                        zoneReached++;
                        break;
                    }
                }

                if (zoneReached == zones.Length)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:F2}");
                }
                else
                {
                    Console.WriteLine($"{driver} - reached {zoneReached}");
                }
            }
        }
    }
}
