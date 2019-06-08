namespace p01._01.Hospital
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Hospital
    {
        static void Main(string[] args)
        {
            var departments = new Dictionary<string, List<string>>();
            var doctors = new Dictionary<string, List<string>>();

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

                if (!departments.ContainsKey(department))
                {
                    departments.Add(department, new List<string>());
                }

                if (!doctors.ContainsKey(doctor))
                {
                    doctors.Add(doctor, new List<string>());
                }

                departments[department].Add(patient);
                doctors[doctor].Add(patient);

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
                    foreach (string patient in departments[input])
                    {
                        Console.WriteLine(patient);
                    }
                }
                else if (tokens.Length == 2)
                {
                    int roomNumber = 0;

                    if (int.TryParse(tokens[1], out roomNumber))
                    {
                        int skip = 3 * (roomNumber - 1);

                        foreach (string patient in departments[tokens[0]]
                            .Skip(skip)
                            .Take(3)
                            .OrderBy(x => x))
                        {
                            Console.WriteLine(patient);
                        }
                    }
                    else
                    {
                        foreach (string patient in doctors[input]
                            .OrderBy(x => x))
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
