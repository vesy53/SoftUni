using System;

namespace p01Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            double firstTime = double.Parse(Console.ReadLine());
            double secTime = double.Parse(Console.ReadLine());
            double thirdTime = double.Parse(Console.ReadLine());

            double hour = 0.0166666667;

            double distanceSpeed = speed * (firstTime * hour);
            double increase = speed + speed * 0.1;
            secTime *= hour * increase;
            double decrease = increase - increase * 0.05;
            thirdTime *= hour * decrease;
            double total = distanceSpeed + secTime + thirdTime;

            Console.WriteLine($"{total:F2}");
        }
    }
}
