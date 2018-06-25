using System;

class p11PriceChangeAlert
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        double border = double.Parse(Console.ReadLine());
        double last = double.Parse(Console.ReadLine());

        for (int i = 0; i < number - 1; i++)
        {
            double price = double.Parse(Console.ReadLine());

            double different = Percent(last, price);
            bool isSignificantDifference = isDifferent(different, border);
            string message = GetTotalPrice(price, last, different, isSignificantDifference);

            Console.WriteLine(message);

            last = price;
        }
    }

    static string GetTotalPrice(double price, double last, double diff, bool isTrueOrFalse)
    {
        string result = "";

        if (diff == 0)
        {
            result = string.Format("NO CHANGE: {0}", price);
        }
        else if (!isTrueOrFalse)
        {
            result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, price, diff * 100);
        }
        else if (isTrueOrFalse && (diff > 0))
        {
            result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, price, diff * 100);
        }
        else if (isTrueOrFalse && (diff < 0))
        {
            result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, price, diff * 100);
        }

        return result;
    }

    static bool isDifferent(double border, double isDiff)
    {
        if (Math.Abs(border) >= isDiff)
        {
            return true;
        }

        return false;
    }

    static double Percent(double last, double price)
    {
        double result = (price - last) / last;
        return result;
    }
}

