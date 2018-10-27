using System;

namespace p03EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double age = double.Parse(Console.ReadLine());
            int employeeID = int.Parse(Console.ReadLine());
            double monthlySalary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}\r\nAge: {age}\r\n" +
                $"Employee ID: {employeeID:D8}\r\nSalary: {monthlySalary:F2}");
        }
    }
}
