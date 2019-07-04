namespace p03._01.StudentSystem
{
    using System;
    using System.Collections.Generic;

    public class StudentSystem
    {
        private Dictionary<string, Student> repo;

        public StudentSystem()
        {
            this.Repo = new Dictionary<string, Student>();
        }

        public Dictionary<string, Student> Repo
        {
            get { return repo; }
            private set { repo = value; }
        }

        public void ParseCommand()
        {
            string[] input = Console.ReadLine()
                .Split();

            string command = input[0];

            if (command.Equals("Create"))
            {
                string name = input[1];
                int age = int.Parse(input[2]);
                double grade = double.Parse(input[3]);

                if (!repo.ContainsKey(name))
                {
                    Student student = new Student(name, age, grade);

                    this.Repo[name] = student;
                }
            }
            else if (command.Equals("Show"))
            {
                string name = input[1];

                if (this.Repo.ContainsKey(name))
                {
                    Student student = this.Repo[name];

                    string view = $"{student.Name} is {student.Age} years old.";

                    if (student.Grade >= 5.00)
                    {
                        view += " Excellent student.";
                    }
                    else if (student.Grade < 5.00 && 
                        student.Grade >= 3.50)
                    {
                        view += " Average student.";
                    }
                    else
                    {
                        view += " Very nice person.";
                    }

                    Console.WriteLine(view);
                }

            }
            else if (command.Equals("Exit"))
            {
                Environment.Exit(0);
            }
        }
    }
}

