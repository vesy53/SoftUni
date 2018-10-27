namespace p01._01.SoftuniCoffeeOrders
{
    using System;
    using System.Globalization;

    class SoftuniCoffeeOrders
    {
        static void Main(string[] args)
        {
            int countOrders = int.Parse(Console.ReadLine());

            decimal totalPrice = 0.0m;

            for (int i = 0; i < countOrders; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime
                    .ParseExact(
                        Console.ReadLine(),
                        "d/M/yyyy",
                        CultureInfo
                        .InvariantCulture);
                decimal capsulesNums = decimal.Parse(Console.ReadLine());

                int year = date.Year;
                int month = date.Month;
                int daysInMonth = DateTime.DaysInMonth(year, month);

                decimal sum = daysInMonth * capsulesNums * price;

                Console.WriteLine($"The price for the coffee is: ${sum:F2}");

                totalPrice += sum;
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
