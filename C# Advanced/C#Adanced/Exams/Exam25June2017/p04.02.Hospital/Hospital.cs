namespace p04._02.Hospital
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Hospital
    {
        static void Main(string[] args)
        {
            var departmentsData = new Dictionary<string, List<string>>();
            var doctorsData = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input.Equals("Output") == false)
            {
                string[] tokens = input
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string department = tokens[0];
                string doctor = tokens[1] + " " + tokens[2];
                string patient = tokens[3];

                if (!departmentsData.ContainsKey(department))
                {
                    departmentsData.Add(department, new List<string>());
                }

                if (departmentsData[department].Count < 60)
                {
                    departmentsData[department].Add(patient);
                }

                if (!doctorsData.ContainsKey(doctor))
                {
                    doctorsData.Add(doctor, new List<string>());
                }

                doctorsData[doctor].Add(patient);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input.Equals("End") == false)
            {
                string[] tokens = input
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                if (tokens.Length == 1)
                {
                    string currDepartment = tokens[0];

                    foreach (var patient in departmentsData[currDepartment])
                    {
                        Console.WriteLine(patient);
                    }
                }
                else if (tokens.Length == 2)
                {
                    int roomNum = 0;

                    if (int.TryParse(tokens[1], out roomNum))
                    {
                        int skip = 3 * (roomNum - 1);

                        foreach (var patient in departmentsData[tokens[0]]
                            .Skip(skip)
                            .Take(3)
                            .OrderBy(p => p))
                        {
                            Console.WriteLine(patient);
                        }
                    }
                    else
                    {
                        foreach (var patient in doctorsData[input]
                            .OrderBy(p => p))
                        {
                            Console.WriteLine(patient);
                        }
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}