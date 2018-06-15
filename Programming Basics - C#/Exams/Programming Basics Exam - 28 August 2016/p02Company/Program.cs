using System;

namespace p02Company
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededHours = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int numPerson = int.Parse(Console.ReadLine());

            double dayForTraining = (days - days * 0.1) * 8;
            numPerson *= 2 * days;
            double totalHours = Math.Floor(dayForTraining + numPerson);

            if (totalHours >=neededHours)
            {
                totalHours -= neededHours;

                Console.WriteLine($"Yes!{totalHours} hours left.");
            }
            else if (totalHours <neededHours)
            {
                neededHours -= totalHours;

                Console.WriteLine($"Not enough time!{neededHours} hours needed.");
            }
        }
    }
}
