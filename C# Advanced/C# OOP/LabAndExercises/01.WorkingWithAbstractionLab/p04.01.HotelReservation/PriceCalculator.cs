namespace p04._01.HotelReservation
{
    using System;

    public static class PriceCalculator
    {
        public static decimal Calculate(Reservation reservation)
        {
            string season = reservation.Season;
            string discountTypeStr = reservation.DiscountType;

            int numberSeason = (int)Enum.Parse(typeof(Season), season);
            int discountTypeInt = (int)Enum.Parse(typeof(Discount), discountTypeStr);

            decimal discount = (100m - discountTypeInt) / 100;

            decimal totalPrice = reservation.PricePerDay * 
                                 reservation.CountDays * 
                                 numberSeason * 
                                 discount;

            return totalPrice;
        }
    }
}
