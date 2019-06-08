namespace p06._01.CompanyRoster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var employeeData = new Dictionary<string, List<Employee>>();

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

                if (!employeeData.ContainsKey(department))
                {
                    employeeData.Add(department, new List<Employee>());
                }

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

                employeeData[department].Add(employee);
            }

            decimal maxAverage = 0;
            StringBuilder builder = new StringBuilder();

            foreach (var employee in employeeData)
            {
                string department = employee.Key;
                List<Employee> employees = employee.Value;

                decimal average = employees.Average(e => e.Salary);

                if (average > maxAverage)
                {
                    maxAverage = average;
                    builder = new StringBuilder();

                    builder
                        .AppendLine($"Highest Average Salary: {department}");

                    foreach (var item in employees
                        .OrderByDescending(i => i.Salary))
                    {
                        string name = item.Name;
                        decimal salary = item.Salary;
                        string email = item.Email;
                        int age = item.Age;

                        builder
                            .AppendLine($"{name} {salary:F2} {email} {age}");
                    }
                }
            }

            Console.WriteLine(builder.ToString().TrimEnd());

            //var result = employeeData
            //    .OrderByDescending(e => e.Value.Average(s => s.Salary))
            //    .Take(1)
            //    .ToDictionary(x => x.Key, y => y.Value);

            //foreach (var employee in result)
            //{
            //    string department = employee.Key;
            //    List<Employee> employees = employee.Value;

            //    Console.WriteLine(
            //        $"Highest Average Salary: {department}");

            //    foreach (Employee itemData in employees
            //        .OrderByDescending(x => x.Salary))
            //    {
            //        string name = itemData.Name;
            //        decimal salary = itemData.Salary;
            //        string email = itemData.Email;
            //        int age = itemData.Age;

            //        Console.WriteLine(
            //            $"{name} {salary} {email} {age}");
            //    }
            //}
        }
    }
}
