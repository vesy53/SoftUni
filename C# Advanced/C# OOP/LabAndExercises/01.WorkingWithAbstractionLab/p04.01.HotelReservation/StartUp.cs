namespace p04._01.HotelReservation
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Reservation reservation = new Reservation(input);

            decimal totalPrice = PriceCalculator
                .Calculate(reservation);

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
