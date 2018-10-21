namespace p10._01.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    class StudentGroups
    {
        static void Main(string[] args)
        {
            List<Town> towns = ReadTownsAndStudents();

            List<Group> groups = DistributeStudentsIntroGroups(towns);

            PrintStudentsGroups(groups);
        }

        static void PrintStudentsGroups(List<Group> groups)
        {
            int countGroups = groups
                .Count;
            int countTowns = groups
                .Select(x => x.Town.TownName)
                .Distinct()
                .Count();

            Console.WriteLine(
                $"Created {countGroups} groups in {countTowns} towns:");

            foreach (var group in groups
                .OrderBy(x => x.Town.TownName))
            {
                string townName = group
                    .Town
                    .TownName;
                List<string> emails = group
                    .Students
                    .Select(x => x.Email)
                    .ToList();

                Console.WriteLine(
                    $"{townName} => " + string.Join(", ", emails));
            }
        }

        static List<Group> DistributeStudentsIntroGroups(List<Town> towns)
        {
            List<Group> groups = new List<Group>();

            foreach (Town town in towns)
            {
                var sortedStudents = town
                    .Students
                    .OrderBy(x => x.RegistrationDate)
                    .ThenBy(x => x.Name)
                    .ThenBy(x => x.Email)
                    .ToList();

                while (sortedStudents.Any())
                {
                    Group newGroups = new Group();
                    newGroups.Town = town;
                    newGroups.Students = sortedStudents
                        .Take(newGroups.Town.SeatsCount)
                        .ToList();

                    sortedStudents = sortedStudents
                        .Skip(newGroups.Town.SeatsCount)
                        .ToList();

                    groups.Add(newGroups);
                }
            }

            return groups;
        }

        static List<Town> ReadTownsAndStudents()
        {
            string input = Console.ReadLine();

            List<Town> towns = new List<Town>();

            while (input.Equals("End") == false)
            {
                if (input.Contains(" => "))
                {
                    string[] inputTowns = input
                        .Split(new string[] { " => "},
                            StringSplitOptions
                            .RemoveEmptyEntries);

                    string currentTown = inputTowns[0];
                    string[] seatsCountStr = inputTowns[1]
                        .Split(' ');
                    int seatsCount = int.Parse(seatsCountStr[0]);

                    Town townObj = new Town()
                    {
                        TownName = currentTown,
                        SeatsCount = seatsCount,
                        Students = new List<Student>()
                    };

                    towns.Add(townObj);
                }
                else
                {
                    string[] inputStudent = input
                        .Split(new char[] { '|' },
                            StringSplitOptions
                            .RemoveEmptyEntries);

                    string studentName = inputStudent[0]
                        .Trim();
                    string email = inputStudent[1]
                        .Trim();
                    DateTime regDate = DateTime
                        .ParseExact(
                            inputStudent[2]
                                .Trim(),
                            "d-MMM-yyyy",
                            CultureInfo
                            .InvariantCulture);

                    Student newStudent = new Student()
                    {
                        Name = studentName,
                        Email = email,
                        RegistrationDate = regDate
                    };

                    towns.Last().Students.Add(newStudent);
                }


                input = Console.ReadLine();
            }

            return towns;
        }
    }

    class Student
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime RegistrationDate { get; set; }
    }

    class Town
    {
        public string TownName { get; set; }

        public int SeatsCount { get; set; }

        public List<Student> Students { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }

        public List<Student> Students { get; set; }
    }
}
