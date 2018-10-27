namespace p02._01.SoftuniCoffeeOrders
{
    using System;
    using System.Linq;
    using System.Globalization;

    class SoftuniCoffeeOrders
    {
        static void Main(string[] args)
        {
            int countOrders = int.Parse(Console.ReadLine());

            decimal totalPrice = 0.0m;

            for (int i = 0; i < countOrders; i++)
            {
                decimal priceCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderData = DateTime
                    .ParseExact(
                        Console.ReadLine(), 
                        "d/M/yyyy", 
                        CultureInfo
                        .InvariantCulture);
                decimal numsCapsule = decimal.Parse(Console.ReadLine());

                int year = orderData.Year;
                int month = orderData.Month;
                int daysInMonth = DateTime.DaysInMonth(year, month);

                decimal sum = (daysInMonth * numsCapsule) * priceCapsule;

                totalPrice += sum;

                Console.WriteLine(
                    $"The price for the coffee is: ${sum:F2}");
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
