using System;
using System.Collections.Generic;

class FilterBase2
{
    static void Main(string[] args)
    {
        Dictionary<string, int> employedAges = new Dictionary<string, int>();
        Dictionary<string, double> employedSalary = new Dictionary<string, double>();
        Dictionary<string, string> employedPosition = new Dictionary<string, string>();

        string[] inputParameters = Console.ReadLine()
            .Split(" -> ".ToCharArray()
                , StringSplitOptions
                .RemoveEmptyEntries);

        while (inputParameters[0] != "filter")
        {
            string name = inputParameters[0];
            string secondParameter = inputParameters[1];

            bool isAge = int.TryParse(secondParameter, out int age);
            bool isSalary = double.TryParse(secondParameter, out double salary);

            if (isAge)
            {
                employedAges.Add(name, age);
            }
            else if (isSalary)
            {
                employedSalary.Add(name, salary);
            }
            else
            {
                employedPosition.Add(name, secondParameter);
            }

            inputParameters = Console.ReadLine()
                .Split(" -> ".ToCharArray()
                    , StringSplitOptions
                    .RemoveEmptyEntries);
        }

        inputParameters = Console.ReadLine()
            .Split(" -> ".ToCharArray()
                , StringSplitOptions
                .RemoveEmptyEntries);

        switch (inputParameters[0])
        {
            case "Age":
                PrintAge(employedAges);
                break;
            case "Salary":
                PrintSalary(employedSalary);
                break;
            case "Position":
                PrintPosition(employedPosition);
                break;
        }
    }

    static void PrintPosition(Dictionary<string, string> positionDict)
    {
        foreach (KeyValuePair<string, string> position in positionDict)
        {
            Console.WriteLine($"Name: {position.Key}");
            Console.WriteLine($"Position: {position.Value}");
            Console.WriteLine(new string('=', 20));
        }
    }

    static void PrintSalary(Dictionary<string, double> salaryDict)
    {
        foreach (KeyValuePair<string, double> salary in salaryDict)
        {
            Console.WriteLine($"Name: {salary.Key}");
            Console.WriteLine($"Salary: {salary.Value:F2}");
            Console.WriteLine(new string('=', 20));
        }
    }

    static void PrintAge(Dictionary<string, int> ageDict)
    {
        foreach (KeyValuePair<string, int> age in ageDict)
        {
            Console.WriteLine($"Name: {age.Key}");
            Console.WriteLine($"Age: {age.Value}");
            Console.WriteLine(new string('=', 20));
        }
    }
}


