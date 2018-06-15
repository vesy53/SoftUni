using System;

namespace p01DailyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int workDaysInMonth = int.Parse(Console.ReadLine());
            double moneyForDays = double.Parse(Console.ReadLine());
            double exchangeRate = double.Parse(Console.ReadLine());

            double monthlySalary = workDaysInMonth * moneyForDays;
            double annualIncome = monthlySalary * 12 + monthlySalary * 2.5;
            double tax = annualIncome * 0.25;
            double totalAnnualIncome = (annualIncome - tax) * exchangeRate;
            double result = totalAnnualIncome / 365;

            Console.WriteLine($"{result:F2}");
        }
    }
}
