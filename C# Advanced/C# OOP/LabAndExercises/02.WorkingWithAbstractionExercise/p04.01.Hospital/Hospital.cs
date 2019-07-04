namespace p04._01.Hospital
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Hospital
    {
        public static void Main()
        {
            var doktors = new Dictionary<string, List<string>>();
            var departments = new Dictionary<string, List<List<string>>>();

            string command = Console.ReadLine();

            while (command != "Output")
            {
                string[] input = command
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string department = input[0];
                string firstName = input[1];
                string secondName = input[2];
                string patient = input[3];

                string doctorName = $"{firstName} {secondName}";

                if (!doktors.ContainsKey(doctorName))
                {
                    doktors[doctorName] = new List<string>();
                }

                if (!departments.ContainsKey(department))
                {
                    departments[department] = new List<List<string>>();

                    for (int room = 0; room < 20; room++)
                    {
                        departments[department].Add(new List<string>());
                    }
                }

                bool isFreeBed = departments[department]
                    .SelectMany(x => x)
                    .Count() < 60;

                if (isFreeBed)
                {
                    int room = 0;

                    doktors[doctorName].Add(patient);

                    for (int i = 0; i < departments[department].Count; i++)
                    {
                        if (departments[department][i].Count < 3)
                        {
                            room = i;
                            break;
                        }
                    }

                    departments[department][room].Add(patient);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] args = command
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries);

                if (args.Length == 1)
                {
                    string department = args[0];

                    var patientsInDepartment = departments[department]
                        .Where(x => x.Count > 0)
                        .SelectMany(x => x);

                    Console.WriteLine(
                        string.Join(Environment.NewLine, patientsInDepartment));
                }
                else if (args.Length == 2)
                {
                    bool isRoom = int.TryParse(args[1], out int room);

                    if (isRoom)
                    {
                        string department = args[0];

                        var patientsInTheRoom = departments[department][room - 1]
                            .OrderBy(x => x);

                        Console.WriteLine(
                            string.Join(Environment.NewLine, patientsInTheRoom));
                    }
                    else
                    {
                        string doctorName = $"{args[0]} {args[1]}";

                        var patientsDoctor = doktors[doctorName]
                            .OrderBy(x => x);

                        Console.WriteLine(
                            string.Join(Environment.NewLine, patientsDoctor));
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
