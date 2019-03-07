namespace p03._01.EnduranceRally
{
    using System;
    using System.Linq;

    class EnduranceRally
    {
        static void Main(string[] args)
        {
            string[] driversNames = Console.ReadLine()
                .Split();
            double[] zones = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            int[] checkpointIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < driversNames.Length; i++)
            {
                double startFuel = 0;

                foreach (var letter in driversNames[i])
                {
                    char firstChar = letter;
                    startFuel = firstChar;
                    break;
                }                

                for (int j = 0; j < zones.Length; j++)
                {
                    if (checkpointIndexes.Contains(j))
                    {
                        startFuel += zones[j];
                    }
                    else
                    {
                        startFuel -= zones[j];
                    }

                    if (startFuel <= 0)
                    {
                        Console.WriteLine(
                            $"{driversNames[i]} - reached {j}");
                        break;
                    }
                }

                if(startFuel > 0)
                {
                    Console.WriteLine(
                        $"{driversNames[i]} - fuel left {startFuel:F2}");
                }
            }
        }
    }
}
