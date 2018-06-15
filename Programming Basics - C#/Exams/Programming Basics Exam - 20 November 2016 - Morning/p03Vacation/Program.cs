using System;

namespace p03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numElderly = int.Parse(Console.ReadLine());
            int numStudents = int.Parse(Console.ReadLine());
            int numNight = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();

            double priceElderlys = 0.0;
            double priceStudents = 0.0;
            int totalPerson = numElderly + numStudents;


            if (transport == "train")
            {
                priceElderlys = 24.99;
                priceStudents = 14.99;

                if (totalPerson >= 50)
                {
                    priceElderlys *= 0.5;
                    priceStudents *= 0.5;
                }
            }
            else if (transport == "bus")
            {
                priceElderlys = 32.50;
                priceStudents = 28.50;
            }
            else if (transport == "boat")
            {
                priceElderlys = 42.99;
                priceStudents = 39.99;
            }
            else if (transport == "airplane")
            {
                priceElderlys = 70;
                priceStudents = 50;
            }

            double priceTransport = numElderly * priceElderlys + numStudents * priceStudents;
            priceTransport *= 2;
            double priceHotel = numNight * 82.99;
            double commission = (priceTransport + priceHotel) * 0.1;
            double total = priceTransport + priceHotel + commission;

            Console.WriteLine($"{total:f2}");
        }
    }
}
