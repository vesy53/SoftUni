namespace p06._02.CompanyRoster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine()
                   .Split(' ',
                       StringSplitOptions
                       .RemoveEmptyEntries);

                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string position = input[2];
                string department = input[3];

                Employee employee = new Employee(
                    name,
                    salary,
                    position,
                    department);

                if (input.Length == 5)
                {
                    string emailOrAge = input[4];

                    bool isAge = int.TryParse(emailOrAge, out int age);

                    if (isAge)
                    {
                        employee.Age = age;
                    }
                    else
                    {
                        employee.Email = emailOrAge;
                    }
                }
                else if (input.Length == 6)
                {
                    string email = input[4];
                    int age = int.Parse(input[5]);

                    employee.Email = email;
                    employee.Age = age;
                }

                employees.Add(employee);
            }

            string topDepartment = employees
                .GroupBy(e => e.Department)
                .OrderByDescending(e => e.Select(s => s.Salary).Average())
                .FirstOrDefault()
                .Key;
            //second method
            //string topDepartment = employees
            //    .GroupBy(x => x.Department)
            //    .ToDictionary(x => x.Key, y => y.Select(s => s))
            //    .OrderByDescending(x => x.Value.Average(s => s.Salary))
            //    .FirstOrDefault()
            //    .Key;

            Console.WriteLine(
               $"Highest Average Salary: {topDepartment}");

            foreach (Employee employee in employees
                .Where(e => e.Department == topDepartment)
                .OrderByDescending(e => e.Salary))
            {
                string name = employee.Name;
                decimal salary = employee.Salary;
                string email = employee.Email;
                int age = employee.Age;

                Console.WriteLine($"{name} {salary:F2} {email} {age}");
            }

            //third method
            //var result = employees
            //    .GroupBy(e => e.Department)
            //    .Select(d => new
            //    {
            //        Department = d.Key,
            //        AverageSalary = d.Average(e => e.Salary),
            //        Employees = d.OrderByDescending(emp => emp.Salary).ToList()
            //    })
            //    .OrderByDescending(d => d.AverageSalary)
            //    .FirstOrDefault();
            //
            //Console.WriteLine($"Highest Average Salary: {result.Department}");
            //
            //foreach (var employee in result.Employees)
            //{
            //    Console.WriteLine(
            //        $"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            //}
        }
    }
}
