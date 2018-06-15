using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01Money
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoins = double.Parse(Console.ReadLine());
            double numChineseYuan = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            bitcoins *= 1168;
            numChineseYuan *= 0.15;
            numChineseYuan *= 1.76;
            double total = (bitcoins + numChineseYuan) / 1.95;
            commission *= total / 100;
            double totalCommission = total - commission;

            Console.WriteLine($"{totalCommission:F2}");
        }
    }
}
