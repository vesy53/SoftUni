namespace p04._01.HotelReservation
{
    using System;

    public class Reservation
    {
        public decimal PricePerDay { get; private set; }

        public int CountDays { get; private set; }

        public string Season { get; private set; }

        public string DiscountType { get; private set; }

        public Reservation(string reservation)
        {
            string[] reservationInfo = reservation
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries);

            this.PricePerDay = decimal.Parse(reservationInfo[0]);
            this.CountDays = int.Parse(reservationInfo[1]);
            this.Season = reservationInfo[2];
            this.DiscountType = "None";

            if (reservationInfo.Length > 3)
            {
                this.DiscountType = reservationInfo[3];
            }
        }
    }
}
