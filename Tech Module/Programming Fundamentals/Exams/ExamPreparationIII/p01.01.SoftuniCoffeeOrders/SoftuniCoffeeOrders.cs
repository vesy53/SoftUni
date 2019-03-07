namespace p01._01.SoftuniCoffeeOrders
{
    using System;
    using System.Globalization;

    class SoftuniCoffeeOrders
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());

            decimal totalPrice = 0.0m;

            for (int i = 0; i < countOfOrders; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(
                    Console.ReadLine(),
                    "d/M/yyyy", 
                    CultureInfo
                        .InvariantCulture);
                long countCapsule = long.Parse(Console.ReadLine());

                int year = date.Year;
                int month = date.Month;
                int days = DateTime.DaysInMonth(year, month);
                
                decimal orderPrice = (days * countCapsule) * price;

                totalPrice += orderPrice;

                Console.WriteLine(
                    $"The price for the coffee is: ${orderPrice:F2}");
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
