namespace p03._02.EnduranceRally
{
    using System;
    using System.Linq;
    using System.Text;

    class EnduranceRally2
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

            StringBuilder result = new StringBuilder();

            foreach (var driver in driversNames)
            {
                char firstLetter = char.Parse(driver.Substring(0, 1));
                double driverFuel = (double)firstLetter;
                bool hasFuel = true;

                for (int i = 0; i < zones.Length; i++)
                {
                    if (checkpointIndexes.Contains(i))
                    {
                        driverFuel += zones[i];
                    }
                    else
                    {
                        driverFuel -= zones[i];
                    }

                    if (driverFuel <= 0)
                    {
                        result.Append($"{driver} - reached {i}{Environment.NewLine}");
                        hasFuel = false;
                        break;
                    }
                }

                if (hasFuel)
                {
                    result.Append($"{driver} - fuel left {driverFuel:f2}{Environment.NewLine}");
                }
            }

            Console.WriteLine(result);
        }
    }
}
