using System;

namespace p01DayOfWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string[] daysName =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            switch (num)
            {
                case 1:
                    Console.WriteLine(daysName[0]);
                    break;
                case 2:
                    Console.WriteLine(daysName[1]);
                    break;
                case 3:
                    Console.WriteLine(daysName[2]);
                    break;
                case 4:
                    Console.WriteLine(daysName[3]);
                    break;
                case 5:
                    Console.WriteLine(daysName[4]);
                    break;
                case 6:
                    Console.WriteLine(daysName[5]);
                    break;
                case 7:
                    Console.WriteLine(daysName[6]);
                    break;
                default:
                    Console.WriteLine("Invalid Day!");
                    break;
            }
        }
    }
}
