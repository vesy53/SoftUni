using System;
using System.Collections.Generic;

class FilterBase
{
    static void Main(string[] args)
    {
        Dictionary<string, int> ageDict = new Dictionary<string, int>();
        Dictionary<string, double> salaryDict = new Dictionary<string, double>();
        Dictionary<string, string> positionDict = new Dictionary<string, string>();

        string[] inputParameters = Console.ReadLine()
            .Split(new char[] { ' ', '-', '>' }
                , StringSplitOptions
                .RemoveEmptyEntries);

        while (inputParameters[0] != "filter" && inputParameters[1] != "base")
        {
            string name = inputParameters[0];
            string secondParameter = inputParameters[1];

            int age; 
            double salary;

            if (int.TryParse(secondParameter, out age))
            {
                ageDict.Add(name, age);
            }
            else if (Double.TryParse(secondParameter, out salary))
            {
                salaryDict.Add(name, salary);
            }
            else
            {
                positionDict.Add(name, secondParameter);
            }

            inputParameters = Console.ReadLine()
            .Split(new char[] { ' ', '-', '>' }
                , StringSplitOptions
                .RemoveEmptyEntries);
        }

        inputParameters = Console.ReadLine()
           .Split(new char[] { ' ', '-', '>' }
               , StringSplitOptions
               .RemoveEmptyEntries);

        if (inputParameters[0].Equals("Age"))
        {
            foreach (KeyValuePair<string, int> age in ageDict)
            {
                Console.WriteLine($"Name: {age.Key}");
                Console.WriteLine($"{inputParameters[0]}: {age.Value}");
                Console.WriteLine(new string('=', 20));
            }
        }
        else if (inputParameters[0].Equals("Salary"))
        {
            foreach (KeyValuePair<string, double> salary in salaryDict)
            {
                Console.WriteLine($"Name: {salary.Key}");
                Console.WriteLine($"{inputParameters[0]}: {salary.Value:F2}");
                Console.WriteLine(new string('=', 20));
            }
        }
        else if (inputParameters[0].Equals("Position"))
        {
            foreach (KeyValuePair<string, string> position in positionDict)
            {
                Console.WriteLine($"Name: {position.Key}");
                Console.WriteLine($"{inputParameters[0]}: {position.Value}");
                Console.WriteLine(new string('=', 20));
            }
        }
    }
}


