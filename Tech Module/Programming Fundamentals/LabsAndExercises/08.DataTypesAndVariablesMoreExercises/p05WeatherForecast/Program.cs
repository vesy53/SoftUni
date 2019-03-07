using System;

namespace p05WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            double num = double.Parse(number);
                      
            if (num % 1 == 0)
            {
                if (num >= sbyte.MinValue && num <= sbyte.MaxValue)
                {
                    Console.WriteLine("Sunny");
                }
                else if (num >= int.MinValue && num <= int.MaxValue)
                {
                    Console.WriteLine("Cloudy");
                }
                else if (num >= long.MinValue && num <= long.MaxValue)
                {
                    Console.WriteLine("Windy");
                }
            }          
            else if (number.Contains("."))
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}
