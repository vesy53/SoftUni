using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01TileRepair
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthLanding = double.Parse(Console.ReadLine());
            double widthOfTile = double.Parse(Console.ReadLine());
            double lengthOfTile = double.Parse(Console.ReadLine());
            double widthOfBench = double.Parse(Console.ReadLine());
            double lengthOfBench = double.Parse(Console.ReadLine());

            double totalLanding = lengthLanding * lengthLanding;
            double totalBench = widthOfBench * lengthOfBench;
            double coverageArea = totalLanding - totalBench;
            double coverageTile = widthOfTile * lengthOfTile;
            double totalTile = coverageArea / coverageTile;
            double totalTimes = totalTile * 0.2;

            Console.WriteLine($"{totalTile:F2}");
            Console.WriteLine($"{totalTimes:F2}");

        }
    }
}
