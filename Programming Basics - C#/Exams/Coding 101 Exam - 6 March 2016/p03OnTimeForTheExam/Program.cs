using System;

namespace p03OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minutesOfExam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minutesOfArrival = int.Parse(Console.ReadLine());

            int totalMinOfExam = hourOfExam * 60 + minutesOfExam;
            int totalMinOfArrival = hourOfArrival * 60 + minutesOfArrival;
            int difference = totalMinOfExam - totalMinOfArrival;

            if (difference >= 0 && difference <= 30)
            {
                int diffMin = difference % 60;

                Console.WriteLine("On time");

                if (diffMin != 0)
                {
                    Console.WriteLine(
                        $"{diffMin} minutes before the start");
                }
            }
            else if (difference < 0)
            {
                difference = Math.Abs(difference);
                int diffHour = difference / 60;
                int diffMin = difference % 60;

                Console.WriteLine("Late");

                if (diffHour != 0)
                {
                    Console.WriteLine(
                        $"{diffHour}:{diffMin:00} hours after the start");
                }
                else
                {
                    Console.WriteLine(
                         $"{diffMin} minutes after the start");
                }
            }
            else if (difference > 30)
            {
                int diffHours = difference / 60;
                int diffMin = difference % 60;

                Console.WriteLine("Early");

                if (diffHours != 0)
                {
                    Console.WriteLine(
                        $"{diffHours}:{diffMin:00} hours before the start");
                }
                else
                {
                    Console.WriteLine(
                        $"{diffMin} minutes before the start");
                }
            }
        }
    }
}
