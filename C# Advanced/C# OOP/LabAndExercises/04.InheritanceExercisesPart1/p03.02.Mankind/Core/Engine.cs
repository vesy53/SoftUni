namespace p03._02.Mankind.Core
{
    using System;

    using p03._01.Mankind.Humans;

    public class Engine
    {
        public void Run()
        {
            try
            {
                string[] studentInfo = Console.ReadLine()
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries);
                string[] workerInfo = Console.ReadLine()
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string studentFirstName = studentInfo[0];
                string studentLastName = studentInfo[1];
                string studentFacultyNumber = studentInfo[2];

                string workerFirstName = workerInfo[0];
                string workerLastName = workerInfo[1];
                decimal weekSalary = decimal.Parse(workerInfo[2]);
                decimal workHoursPerDay = decimal.Parse(workerInfo[3]);

                Student student = new Student(
                    studentFirstName,
                    studentLastName,
                    studentFacultyNumber);

                Worker worker = new Worker(
                    workerFirstName,
                    workerLastName,
                    weekSalary,
                    workHoursPerDay);

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
