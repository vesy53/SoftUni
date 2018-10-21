namespace p03._01.EnduranceRally
{
    using System;
    using System.Linq;

    class EnduranceRally
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

            for (int i = 0; i < drivers.Length; i++)
            {
                double startFuel = 0.0;
                string currDriver = drivers[i];

                char firstLetter = currDriver.First();
                startFuel = Convert.ToInt32(firstLetter);

                for (int j = 0; j < zones.Length; j++)
                {
                    double currZones = zones[j];

                    if (checkpoints.Contains(j))
                    {
                        startFuel += currZones;
                    }
                    else
                    {
                        startFuel -= currZones;
                    }

                    if (startFuel <= 0)
                    {
                        Console.WriteLine(
                            $"{drivers[i]} - reached {j}");
                        break;
                    }
                }

                if (startFuel > 0)
                {
                    Console.WriteLine(
                        $"{drivers[i]} - fuel left {startFuel:F2}");
                }
            }
        }
    }
}
